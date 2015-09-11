using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Konekti.Framework.Data;

namespace Konekti.Model.Domain
{
    public class Role : Entity<int>
    {
        public virtual string Description { get; set; }

        public override string ToString()
        {
            return "Role [Id=" + Id.ToString() + "]";
        }
    }
}
