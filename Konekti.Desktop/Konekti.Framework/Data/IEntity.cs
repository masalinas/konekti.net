using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konekti.Framework.Data
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
