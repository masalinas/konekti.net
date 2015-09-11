using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using System.IO;

using log4net;

using Konekti.Framework.Configuration;
using Konekti.Framework.Plugin;

namespace Konekti.Workbench.View
{
    public partial class AboutView : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(AboutView));

        private class PluginNode
        {
            public Assembly Assembly { get; set; }
            public Image Image { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Version { get; set; }
            public string Guid { get; set; }

            public override string ToString()
            {
                return Name + "[" + Version + "] " + Guid;
            }
        }

        public AboutView()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                pcLogo.Image = Image.FromFile("logo.jpg");

                leftKonektiDescription.Text = "Konekti\n" +
                                              "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\n" +
                                              "© Thingtrack S.L.\n" +
                                              "All rights reserved.";
                rightKonektiDescription.Text = "Microsoft.NET Framework\n" + 
                                               "Version " + Environment.Version.ToString() + "\n" +
                                               "© Microsoft Corporation.\n" + 
                                               "All rights reserved."; 



                foreach (Konekti.Framework.Plugin.PluginManager.AssemblyPlugin assemblyPlugin in AppContext.Instance.GetPluginManager().getPluginAssemblies())
                {
                    PluginNode pluginNode = new AboutView.PluginNode();
                    pluginNode.Assembly = assemblyPlugin.Assembly;

                    // get assembly name
                    pluginNode.Name = assemblyPlugin.Assembly.GetName().Name;

                    //  get assembly image
                    if (assemblyPlugin.Image != null)
                        pluginNode.Image = Image.FromStream(new MemoryStream(assemblyPlugin.Image));

                    // get assembly description
                    AssemblyDescriptionAttribute assemblyDescriptionAttribute = PluginInspector.GetAttribute<AssemblyDescriptionAttribute>(assemblyPlugin.Assembly, false);

                    if (assemblyDescriptionAttribute != null)
                        pluginNode.Description = assemblyDescriptionAttribute.Description;

                    // get assembly version
                    AssemblyFileVersionAttribute assemblyFileVersionAttribute = PluginInspector.GetAttribute<AssemblyFileVersionAttribute>(assemblyPlugin.Assembly, false);

                    if (assemblyFileVersionAttribute != null)
                        pluginNode.Version = assemblyFileVersionAttribute.Version.ToString();

                    // get assembly guid
                    GuidAttribute guidAttribute = PluginInspector.GetAttribute<GuidAttribute>(assemblyPlugin.Assembly, false);

                    if (guidAttribute != null)
                        pluginNode.Guid = guidAttribute.Value.ToString();

                    lbPlugins.Items.Add(pluginNode);
                }

                // select first plugin
                if (lbPlugins.Items.Count > 0)
                    lbPlugins.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                log.Error(ex);

                throw ex;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbPlugins_SelectedIndexChanged(object sender, EventArgs e)
        {
            PluginNode pluginNode = (PluginNode)lbPlugins.SelectedItem;

            if (pluginNode != null)
            {
                lbAssemblyDescription.Text = pluginNode.Description;
                pcImagePlugin.Image = pluginNode.Image;
            }
        }
    }
}
