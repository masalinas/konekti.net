using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace konekti.framework.Plugin
{
    interface IMenuStripPlugin
    {
        List<MenuStrip> MenuStripPlugin { get; }
    }
}
