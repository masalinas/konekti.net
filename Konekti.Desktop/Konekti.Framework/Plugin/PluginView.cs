using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI;

namespace Konekti.Framework.Plugin
{
    public partial class PluginView : DockContent
    {
        private DockState dockStatePlugin;

        public PluginView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DockState Plugin
        /// </summary>
        [Browsable(true)]
        [Description("DockState Plugin")]
        public virtual DockState DockStatePlugin
        {
            get { return this.dockStatePlugin; }
            set { this.dockStatePlugin = value; }
        }
    }
}
