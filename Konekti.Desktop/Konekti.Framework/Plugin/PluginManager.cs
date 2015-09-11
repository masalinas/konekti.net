using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Konekti.Framework.Plugin
{
    public class PluginManager
    {
        private static PluginManager instance;
        private static List<AssemblyPlugin> assemblyPlugins = new List<AssemblyPlugin>();

        private PluginManager()
        {
        }

        public class AssemblyPlugin
        {
            private byte[] image;
            private Assembly assembly;

            public AssemblyPlugin(Assembly assembly, byte[] image)
            {
                this.image = image;
                this.assembly = assembly;
            }

            public byte[] Image { get { return image; } }
            public Assembly Assembly { get { return assembly; } }
        }

        public static PluginManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PluginManager();
                }

                return instance;
            }
        }

        public void addAssemblyPlugin(AssemblyPlugin assembly)
        {
            PluginManager.assemblyPlugins.Add(assembly);
        }
        public void removeAssemblyPlugin(AssemblyPlugin assembly)
        {
            PluginManager.assemblyPlugins.Remove(assembly);
        }
        public List<AssemblyPlugin> getPluginAssemblies()
        {
            return assemblyPlugins;
        }
        public AssemblyPlugin getAssembly(string name, string version)
        {
            foreach (AssemblyPlugin assemblyPlugin in assemblyPlugins)
            {
                string assemblyName = null;
                string assemblyVersion = null;

                AssemblyDescriptionAttribute assemblyDescriptionAttribute = PluginInspector.GetAttribute<AssemblyDescriptionAttribute>(assemblyPlugin.Assembly, false);

                if (assemblyDescriptionAttribute != null)
                    assemblyName = assemblyDescriptionAttribute.Description;

                AssemblyFileVersionAttribute assemblyFileVersionAttribute = PluginInspector.GetAttribute<AssemblyFileVersionAttribute>(assemblyPlugin.Assembly, false);

                if (assemblyFileVersionAttribute != null)
                    assemblyVersion = assemblyFileVersionAttribute.Version.ToString();

                if (name.Equals(assemblyName) && version.Equals(assemblyVersion))
                    return assemblyPlugin;
            }

            return null;
        }
    }
}
