using Konekti.Framework.Data;
using Konekti.Framework.Plugin;
namespace Konekti.Framework.Configuration
{
    /// <summary>
    /// Konekti Application Context
    /// </summary>
    public class AppContext
    {
        private static AppContext instance;

        private string appPath;

        private AppContext()
        {
        }

        public static AppContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppContext();
                }

                return instance;
            }
        }

        public string GetAppPath()
        {
            return instance.appPath;
        }
        public void SetAppPath(string appPath)
        {
            this.appPath = appPath;
        }
        public PluginManager GetPluginManager()
        {
            return PluginManager.Instance;             
        }
    }
}