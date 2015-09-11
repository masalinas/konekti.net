using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Konekti.Framework.Plugin;

namespace Konekti.Plugin.Msdos
{
    public partial class MainPluginView : PluginView
    {
        private DirectoryInfo dirInfo;

        public MainPluginView()
        {
            InitializeComponent();

            dirInfo = new DirectoryInfo(Application.StartupPath);
            commandPrompt.PromptString = dirInfo.FullName + ">";
        }

        private void commandPrompt_Command(object sender, CommandPrompt.CommandEventArgs e)
        {
            if (e.Command == "cls")
            {
                commandPrompt.ClearMessages();
                e.Cancel = true;
                return;
            }

            if (e.Command == "exit")
            {
                Application.Exit();
            }

            if (e.Command == "date")
            {
                e.Message = "  The current date is : " +
                    DateTime.Now.ToLongDateString();
                return;
            }

            if (e.Command == "time")
            {
                e.Message = "  The current time is : " +
                    DateTime.Now.ToLongTimeString();
                return;
            }

            if (e.Command == "dir")
            {
                string msg = "";

                DirectoryInfo[] di = dirInfo.GetDirectories();
                foreach (DirectoryInfo d in di)
                {
                    msg += "  " + d.LastWriteTime.ToShortDateString()
                        + "\t" + d.LastWriteTime.ToShortTimeString()
                        + "\t<DIR>\t"
                        + "\t" + d.Name + "\n";
                }

                FileInfo[] fi = dirInfo.GetFiles();
                foreach (FileInfo f in fi)
                {
                    msg += "  " + f.LastWriteTime.ToShortDateString()
                        + "\t" + f.LastWriteTime.ToShortTimeString()
                        + "\t\t" + f.Length
                        + "\t" + f.Name + "\n";
                }
                e.Message = msg;
                return;
            }

            if (e.Command == "cd..")
            {
                if (dirInfo.Parent != null)
                    dirInfo = dirInfo.Parent;
                commandPrompt.PromptString = dirInfo.FullName + ">";
                return;
            }

            if (e.Command == "cd\\")
            {
                if (dirInfo.Root != null)
                    dirInfo = dirInfo.Root;
                commandPrompt.PromptString = dirInfo.FullName + ">";
                return;
            }

            if (e.Command.Length > 3 && e.Command.Substring(0, 2) == "cd")
            {
                if (e.Parameters.Length > 1)
                {
                    string path = e.Parameters[1];
                    string newDir = dirInfo.FullName + "\\" + path;

                    path = dirInfo.FullName;
                    dirInfo = new DirectoryInfo(newDir);
                    if (dirInfo.Exists == false)
                    {
                        dirInfo = new DirectoryInfo(path);
                        e.Message = "Could not find the specified path";
                    }
                    else
                        commandPrompt.PromptString = dirInfo.FullName + ">";

                    return;
                }
            }

            // Show error message
            e.Message = "'" + e.Command + "' is an unrecognized command";

            // Dont store the command
            e.Record = false;
        }
    }
}
