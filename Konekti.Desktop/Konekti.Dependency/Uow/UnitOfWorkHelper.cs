using System;
using System.Reflection;

using Konekti.Framework.Data;

namespace Konekti.Dependency.Uow
{
    public static class UnitOfWorkHelper
    {
        public static bool IsRepositoryMethod(MethodInfo methodInfo)
        {
            return IsRepositoryClass(methodInfo.DeclaringType);
        }

        public static bool IsRepositoryClass(Type type)
        {
            if (type.GetInterface(typeof(IRepository<,>).FullName) != null)
                return true;

            return false;

            //return typeof(IRepository<,>).IsAssignableFrom(type);
        }

        public static bool HasUnitOfWorkAttribute(MethodInfo methodInfo)
        {
            return methodInfo.IsDefined(typeof(UnitOfWorkAttribute), true);
        }
    }
}