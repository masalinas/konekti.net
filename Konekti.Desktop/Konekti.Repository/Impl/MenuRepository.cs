using System.Linq;

using Konekti.Model.Domain;
using Konekti.Repository.Api;
using Konekti.Repository.Data;

using NHibernate;
using System.Collections.Generic;

namespace Konekti.Repository.Impl
{
    public class MenuRepository : NhRepositoryBase<Menu, int>, IMenuRepository
    {
        public IList<Menu> GetMenus()
        {
            IQuery query = Session.CreateQuery("SELECT p FROM Menu p WHERE p.ParentMenu IS null ORDER BY p.Position ASC");

            return query.List<Menu>();
        }
    }
}