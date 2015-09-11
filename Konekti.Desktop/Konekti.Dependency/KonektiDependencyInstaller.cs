using System.Configuration;
using System.Reflection;

using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.MicroKernel;
using Castle.MicroKernel.Context;

//using FluentNHibernate.Cfg;
//using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

using Konekti.Model.Domain;
using Konekti.Repository.Impl;
using Konekti.Service.Impl;
using Konekti.Dependency.Uow;

namespace Konekti.Dependency
{
    public class KonektiDependencyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            // Componen event handler
            container.Kernel.ComponentRegistered += Kernel_ComponentRegistered;

            //Register all components
            container.Register(
                
                //Nhibernate session factory
                Component.For<ISessionFactory>().UsingFactoryMethod<ISessionFactory>(CreateNhSessionFactory).LifeStyle.Singleton,

                //Unitofwork interceptor
                Component.For<NhUnitOfWorkInterceptor>().LifeStyle.Transient,

                //All repositories
                Classes.FromAssembly(Assembly.GetAssembly(typeof(UserRepository))).InSameNamespaceAs<UserRepository>().WithService.DefaultInterfaces().LifestyleTransient(),

                //All services
                Classes.FromAssembly(Assembly.GetAssembly(typeof(UserService))).InSameNamespaceAs<UserService>().WithService.DefaultInterfaces().LifestyleTransient()
            );
        }

        /// <summary>
        /// Creates NHibernate Session Factory.
        /// </summary>
        /// <returns>NHibernate Session Factory</returns>
        private static ISessionFactory CreateNhSessionFactory(IKernel kernel, CreationContext context)
        {
            NHibernate.Cfg.Configuration cfg = new NHibernate.Cfg.Configuration().Configure();            
            cfg.AddAssembly("Konekti.Model");

            // update schema or create one if not exist
            new SchemaUpdate(cfg).Execute(false, true);

            return cfg.BuildSessionFactory();

            /*string connStr = ConfigurationManager.ConnectionStrings["Konekti"].ConnectionString;

            return Fluently.Configure()
                .Database(MySQLConfiguration.Standard.ConnectionString(connStr))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(MenuGroup))))
                .BuildSessionFactory();*/
        }

        private void Kernel_ComponentRegistered(string key, Castle.MicroKernel.IHandler handler)
        {
            //Intercept all methods of all repositories.
            if (UnitOfWorkHelper.IsRepositoryClass(handler.ComponentModel.Implementation))
            {
                handler.ComponentModel.Interceptors.Add(new InterceptorReference(typeof(NhUnitOfWorkInterceptor)));
            }

            //Intercept all methods of classes those have at least one method that has UnitOfWork attribute.
            foreach (var method in handler.ComponentModel.Implementation.GetMethods())
            {
                if (UnitOfWorkHelper.HasUnitOfWorkAttribute(method))
                {
                    handler.ComponentModel.Interceptors.Add(new InterceptorReference(typeof(NhUnitOfWorkInterceptor)));
                    return;
                }
            }
        }
    }
}