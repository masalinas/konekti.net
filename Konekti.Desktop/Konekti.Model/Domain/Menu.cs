using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Konekti.Framework.Data;
using System.Reflection;

namespace Konekti.Model.Domain
{
    public class Menu : Entity<int>
    {
        public virtual string Name { get; set; }
        public virtual int Type { get; set; }
        public virtual string Description { get; set; }
        public virtual string AssemblyName { get; set; }
        public virtual string AssemblyVersion { get; set; }
        public virtual int Position { get; set; }
        public virtual string ShortcutKey { get; set; }
        public virtual byte[] Image { get; set; }
        public virtual bool Visible { get; set; }
        public virtual bool OnLoad { get; set; }
        public virtual Menu ParentMenu { get; set; }
        public virtual IList<Menu> SubMenus { get; set; }
        public virtual Assembly Assembly { get; set; }
        public virtual int ParentMenuId { get; set; }

        public Menu()
        {
            Visible = true;
            OnLoad = false;

            SubMenus = new List<Menu>();
        }

        public override string ToString()
        {
            return "Menu [Id=" + Id.ToString() + "]";
        }
    }
}
