using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Konekti.Framework.Data;
using Konekti.Model.Domain;

namespace Konekti.Repository.Api
{
    public interface IMenuRepository : IRepository<Menu, int>
    {
        IList<Menu> GetMenus();
    }
}
