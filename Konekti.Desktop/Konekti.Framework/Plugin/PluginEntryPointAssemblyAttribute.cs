using System;

namespace Konekti.Framework.Plugin
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class PluginEntryPointAssemblyAttribute : Attribute
    {
        private Type _type;

        /// <summary>
        /// Initializes a new instance of the SnapInAttribute class
        /// </summary>
        /// <param name="t">The type of SnapIn that is exported from this Assembly</param>
        public PluginEntryPointAssemblyAttribute(Type t)
        {
            _type = t;
        }

        /// <summary>
        /// Gets the type of SnapIn that is exported from this Assembly
        /// </summary>
        /// <returns></returns>
        public Type Type
        {
            get
            {
                return _type;
            }
        }

        public override string ToString()
        {
            return "'Plugin Exported from Assembly': " + _type.FullName;
        }
    }
}
