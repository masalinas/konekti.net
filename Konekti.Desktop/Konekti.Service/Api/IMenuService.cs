using System.Collections.Generic;
using Konekti.Model.Domain;

namespace Konekti.Service.Api
{
    public interface IMenuService
    {
        List<Menu> GetAll();

        List<Menu> GetMenus();

        Menu GetById(int id);

        object Insert(Menu menu);

        void Update(Menu menu);

        void Delete(int menuId);
    }
}
