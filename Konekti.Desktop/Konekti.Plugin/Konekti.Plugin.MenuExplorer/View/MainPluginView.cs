using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI;

using XPExplorerBar;

using Konekti.Framework.Plugin;
using Konekti.Framework.Data;
using Konekti.Framework.Configuration;
using Konekti.Service.Api;

namespace Konekti.Plugin.MenuExplorer.View
{
    public partial class MainPluginView : PluginView
    {       
        #region Constructor
        public MainPluginView()
        {
            InitializeComponent();

            //IUserService userService = IoContainer.Resolve<IUserService>();
        }
        #endregion

        #region Private Form Events
        private void frmMenuExplorer_Load(object sender, EventArgs e)
        {
            //Create the Group Vible Panel Commands          
            /*foreach (PluginGroup mg in ContextManager.Context.GetPluginManager().Groups)
            {
                if (mg.Visible == 1)
                {
                    Expando _Expando = new Expando();
                    _Expando.Text = mg.Name;
                    _Expando.TitleImage = mg.Image;
                    _Expando.Animate = true;
                    _Expando.AutoLayout = true;
                    _Expando.SpecialGroup = true;
                    _Expando.ForeColor = Color.Black;

                    _tpKonekti.Expandos.Add(_Expando);

                    foreach (PluginCommand cm in mg.Commands)
                    {
                        if (cm.Visible == 1)
                        {
                            TaskItem _CurrentTaskItem = new TaskItem();

                            _CurrentTaskItem.Text = cm.Name;                            
                            _CurrentTaskItem.Image = cm.Image;                            
                            _CurrentTaskItem.Tag = cm.Id; //Save the plugin                    
                            _CurrentTaskItem.Click += new EventHandler(_CurrentGroupMenu_Click);

                            _Expando.Items.Add(_CurrentTaskItem);
                        }
                    }
                }
            }*/

            // foreverblue.dll is a cut down version of the the 
            // forever blue theme. do not attempt to use this as 
            // a proper theme for XP as Windows may crash due to 
            // several images being removed from the dll to keep
            // file sizes down.  the original forever blue theme 
            // can be found at http://www.themexp.org/
            //this._tpKonekti.UseCustomTheme(Konekti.Framework.Configuration.ApplicationContext.GetAppPath() + "foreverblue.dll");
        }
        #endregion

        #region Private Methods
        private Form GetPluginInstanced(string FormName)
        {
            /*foreach (Form frm in ContextManager.Context.GetMainForm().MdiChildren)
            {
                if (frm.GetType().ToString() == FormName)
                    return frm;
            }*/

            return null;
        }

        private void _CurrentGroupMenu_Click(object sender, EventArgs e)
        {            
            //Get the Custom Attribute
            /*int CommandId = Convert.ToInt32(((TaskItem)sender).Tag);            
            PluginCommand _CurrentCommand = ContextManager.Context.GetPluginManager().GetCommand(CommandId);

            if (_CurrentCommand != null)
            {
                //Get the Custom Attribute                
                object[] PluginAttribute = _CurrentCommand.Assembly.GetCustomAttributes(typeof(Konekti.Framework.Plugins.PluginExportedFromAssemblyAttribute), false);

                if (PluginAttribute.Length == 0)
                {
                    MessageBox.Show("The plugin not have Initial Run Point!", "Konekti Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    //Only Show One plugin
                    Form ActiveForm = GetPluginInstanced(((Konekti.Framework.Plugins.PluginExportedFromAssemblyAttribute)PluginAttribute[0]).Type.ToString());

                    if (ActiveForm != null)
                    {
                        ActiveForm.Activate();
                        return;
                    }

                    PluginForm _InstanceForm = (PluginForm)Activator.CreateInstance(_CurrentCommand.Assembly.GetType(((Konekti.Framework.Plugins.PluginExportedFromAssemblyAttribute)PluginAttribute[0]).Type.ToString()));

                    if (_InstanceForm != null)
                    {
                        _CurrentCommand.InstanceForm = _InstanceForm;
                        _CurrentCommand.MenuStrips = _InstanceForm.MenuStripPlugin;
                        _CurrentCommand.ToolStrips = _InstanceForm.ToolStripPlugin;

                        _InstanceForm.CommandId = CommandId;
                        _InstanceForm.FormClosed += new FormClosedEventHandler(_CurrentGroupMenu_FormClosed);

                        //Show the Form
                        if (_InstanceForm.DockStatePlugin != DockState.Unknown)
                            _InstanceForm.Show(ContextManager.Context.GetDockPanel(), _InstanceForm.DockStatePlugin);
                        else
                        {
                            if (_CurrentCommand.DockStatePlugin != DockState.Unknown)
                                _InstanceForm.Show(ContextManager.Context.GetDockPanel(), _CurrentCommand.DockStatePlugin);
                            else
                                _InstanceForm.Show(ContextManager.Context.GetDockPanel());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Instance Plugin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }*/
        }
        private void _CurrentGroupMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Get the Custom Attribute
            /*int CommandId = Convert.ToInt32(((PluginForm)sender).CommandId);
            PluginCommand _CurrentCommand = ContextManager.Context.GetPluginManager().GetCommand(CommandId);            

            //Unload the Assembly
            _CurrentCommand.InstanceForm = null;*/
        }
        #endregion
    }
}