using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

using WeifenLuo.WinFormsUI;

using log4net;
using log4net.Config;

using Konekti.Framework.Plugin;
using Konekti.Framework.Configuration;
using Konekti.Framework.Data;
using Konekti.Service.Api;
using Menu = Konekti.Model.Domain.Menu;

namespace Konekti.Workbench.View
{
    public partial class MainView : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MainView));

        private IMenuService menuService = null;
        private PluginLoader pluginLoader = new PluginLoader();

        public MainView()
        {
            InitializeComponent();

            try
            {
                GetServices();

                Initialize();
            }            
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.Message, "Error Konekti", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void GetServices()
        {
            try
            {
                menuService = AppContainer.Resolve<IMenuService>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Initialize()
        {
            try
            {              
                log.Info("");
                log.Info("**************************************************************");
                log.Info(" Konekti User Logon                                           ");
                log.Info("**************************************************************");
                log.Info("");

                // load plugings and created Konekti menu
                GenerateMenu();

                log.Info("");
                log.Info("**************************************************************");
                log.Info(" Konekti Menu Generted                                        ");
                log.Info("**************************************************************");
                log.Info("");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        private void MainView_MdiChildActivate(object sender, EventArgs e)
        {
            //Unmerge all ToolStrip of the Console
            //ReverteAllPluginToolStrip();
            //ClearAllPluginToolBar();

            //Merge All ToolStrip of the Plugin                
            //MergeToolStrips();

            //Close All PluginForm
            //CloseAllPluginForm();

            //Open All PluginForms of the Active Plugin
            //OpenAllPluginForm();
        }

        private Form GetPluginInstanced(string FormName)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType().ToString() == FormName)
                    return frm;
            }

            return null;
        }
        private void PluginHandler_Click(object sender, EventArgs e)
        {
            try
            {
                // get assembly [name, version] from menu item entity 
                Menu menuItem = (Menu)((ToolStripMenuItem)sender).Tag;                

                // get plugin metadata attribute entry point                                
                object[] pluginAttributes = menuItem.Assembly.GetCustomAttributes(typeof(PluginEntryPointAssemblyAttribute), false);

                if (pluginAttributes.Length == 0)
                {
                    MessageBox.Show("The plugin not have Initial Run Point!", "Konekti Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // active plugin if is already instanciated
                Form activePluginViewForm = GetPluginInstanced(((PluginEntryPointAssemblyAttribute)pluginAttributes[0]).Type.ToString());

                if (activePluginViewForm != null)
                {
                    activePluginViewForm.Activate();
                    return;
                }

                // get plugin view from plugin metadata attibutes
                PluginView pluginView = (PluginView)Activator.CreateInstance(menuItem.Assembly.GetType(((PluginEntryPointAssemblyAttribute)pluginAttributes[0]).Type.ToString()));

                // show the entry ppoint plugin view in the dock panel
                if (pluginView.DockStatePlugin != WeifenLuo.WinFormsUI.DockState.Unknown)
                    pluginView.Show(dockPanel, pluginView.DockStatePlugin);
                else
                    pluginView.Show(dockPanel);               
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
        private void GenerateSubMenuItem(PluginLoader pluginLoader, ToolStripMenuItem parentMenuItem, Menu menu)
        {
            foreach(Menu mm in menu.SubMenus)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(mm.Name);

                // add image menu item
                if (mm.Image != null)
                    menuItem.Image = Image.FromStream(new MemoryStream(mm.Image));

                // add shorcut menu item
                menuItem.ShowShortcutKeys = true;
                if (mm.ShortcutKey != null)
                {
                    menuItem.ShortcutKeyDisplayString = mm.ShortcutKey;
                    KeysConverter cvt = new KeysConverter();

                    menuItem.ShortcutKeys = (Keys)cvt.ConvertFrom(mm.ShortcutKey);
                }

                // add handler click menu item
                if (mm.Type == Convert.ToInt32(MenuType.COMMAND))
                {
                    // asociate plugin instance assembly
                    mm.Assembly = pluginLoader.LoadAndRun(mm.AssemblyName, mm.AssemblyVersion, mm.Image);

                    menuItem.Tag = mm;
                    menuItem.Click += new EventHandler(PluginHandler_Click);
                }

                parentMenuItem.DropDownItems.Add(menuItem);

                if (mm.Type == Convert.ToInt32(MenuType.MENU))
                    GenerateSubMenuItem(pluginLoader, menuItem, mm);
            }
        }
        private void GenerateMenu()
        {
            List<Menu> menus = null;
            try
            {
                menus = menuService.GetMenus();
            }
            catch(Exception ex)
            {
                throw ex;
            }            

            foreach (Menu menu in menus)
            {                
                ToolStripMenuItem menuItem = new ToolStripMenuItem(menu.Name);
                msKonektiMenuBar.Items.Insert(menu.Position, menuItem);

                GenerateSubMenuItem(pluginLoader, menuItem, menu);                
            }
        }        

        private void tsAbout_Click(object sender, EventArgs e)
        {
            AboutView aboutView = new AboutView();
            aboutView.ShowDialog();
        }
        private void tsExit_Click(object sender, EventArgs e)
        {
            log.Info("");
            log.Info("**************************************************************");
            log.Info(" Konekti Application Closed                                   ");
            log.Info("**************************************************************");
            log.Info("");

            this.Close();
        }
    }
}
