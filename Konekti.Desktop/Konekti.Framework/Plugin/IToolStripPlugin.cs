using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace konekti.framework.Plugin
{
    interface IToolStripPlugin
    {
        List<ToolStrip> ToolStripPlugin { get; }
    }
}
