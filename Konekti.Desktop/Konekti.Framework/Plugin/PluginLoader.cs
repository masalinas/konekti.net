using System;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

using log4net;

using Konekti.Framework.Plugin;
using Konekti.Framework.Configuration;

namespace Konekti.Framework.Plugin
{
    public class PluginLoader
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(PluginLoader));

        public Assembly LoadAndRun(string name, string version, byte[] image)
        {
            // instanciate all plugins from Konekti repository configured in database
            foreach (string file in Directory.GetFiles(AppContext.Instance.GetAppPath() + "\\plugin"))
            {
                try
                {
                    if (Path.GetExtension(file) == ".dll")
                    {
                        AssemblyName assemblyName = AssemblyName.GetAssemblyName(file);

                        if (assemblyName != null && assemblyName.Name == name && 
                            assemblyName.Version.ToString() == version)
                        {
                            Assembly plugingAssembly = Assembly.LoadFile(file);

                            if (plugingAssembly != null)
                            {
                                // add assemply plugin to the manager
                                AppContext.Instance.GetPluginManager().addAssemblyPlugin(new Konekti.Framework.Plugin.PluginManager.AssemblyPlugin(plugingAssembly, image));

                                return plugingAssembly;         
                            }                                            
                        }
                    }
                }
                catch(Exception ex)
                {
                    log.Error(ex.Message);
                    throw ex;
                }
            }
            
            return null;
        }
    }
}
