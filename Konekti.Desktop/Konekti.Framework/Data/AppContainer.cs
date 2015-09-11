using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace Konekti.Framework.Data
{
    public static class AppContainer
    {
        private static IWindsorContainer container = null;

        public static IWindsorContainer Instance {
            get {
                if (container == null)
                    container = new WindsorContainer();                

                return container;
            }            
        }

        public static void Install(params IWindsorInstaller[] installers)
        {
            container.Install(installers);
        }

        public static T Resolve<T>()
        {
            return Instance.Resolve<T>();
        }

        public static void Dispose()
        {
            if (container != null)
                container.Dispose();
        }
    }
}
