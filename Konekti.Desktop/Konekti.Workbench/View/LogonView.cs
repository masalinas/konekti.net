using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Collections;

using log4net;
using log4net.Config;

using Castle.Windsor;
using Castle.Windsor.Installer;

using Konekti.Model.Domain;
using Konekti.Framework.Configuration;
using Konekti.Service.Api;
using Konekti.Framework.Data;
using Konekti.Dependency;
using Konekti.Framework.Plugin;

namespace Konekti.Workbench.View
{
    public partial class LogonView : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LogonView));

        public LogonView()
        {
            InitializeComponent();

            try
            {
                // initialize Konekti and Show Logon View
                initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Konekti", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void initialize()
        {
            try
            {
                // Set Konekti Application Path
                SetAppPath();

                // Set Konekti logger configuration
                SetLog4Net();

                log.Info("");
                log.Info("**************************************************************");
                log.Info(" Konekti Application Configuring                              ");
                log.Info("**************************************************************");
                log.Info("");

                // Set logo application
                SetAppLogo();

                // Create IoC Container and set Konekti Session Factory configuration (Castle Windsor + NHibernate)
                SetIoContainer();

                // Set App version
                SetAppVersion();

                log.Info("");
                log.Info("**************************************************************");
                log.Info(" Konekti Application Configured                               ");
                log.Info("**************************************************************");
                log.Info("");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SetAppPath()
        {
            try
            {
                AppContext.Instance.SetAppPath(System.Environment.CurrentDirectory);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SetLog4Net()
        {
            XmlConfigurator.Configure(new FileInfo(AppContext.Instance.GetAppPath() + "\\Konekti.Workbench.log4net"));
        }
        private void SetAppLogo()
        {
            if (File.Exists("logo.jpg"))
                picLogo.Image = Image.FromFile("logo.jpg");
        }
        private void SetIoContainer()
        {
            try
            {
                AppContainer.Instance.Install(FromAssembly.Containing<KonektiDependencyInstaller>());
                //IoContainer.Instance.Install(FromAssembly.This());  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        
        private void SetAppVersion()
        {
            lblVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            //Test02();           

            MainView mainView = new MainView();
            mainView.ShowDialog(this);
        }

        private void Test02()
        {
            IUserService userService = AppContainer.Resolve<IUserService>();
            IRoleService roleService = AppContainer.Resolve<IRoleService>();

            if (userService != null)
            {
                /*User user = new User();
                user.Name = "Miguel Salinas";
                user.UserName = "masalinas";
                user.Password = "thingtrack";

                Role role = new Role();
                role.Description = "Admnistrador";

                roleService.Insert(role);

                user.AddRole(role);*/

                try
                {
                    //userService.Insert(user);                    
                    User user = userService.GetById(8);

                    List<Role> roles;
                    if (user != null)
                        roles = user.Roles.ToList();
                    
                }
                catch (Exception ex)
                {
                    String error = ex.Message;
                }
            }
        }                       
    }
}
