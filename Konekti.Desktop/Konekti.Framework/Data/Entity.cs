using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konekti.Framework.Data
{
    public class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}
