using System.Collections.Generic;
using System.Linq;

using Konekti.Framework.Data;
using Konekti.Model.Domain;
using Konekti.Repository.Api;
using Konekti.Service.Api;

namespace Konekti.Service.Impl
{
    public class  MenuService : IMenuService
    {
        private readonly IMenuRepository menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;
        }
        
        [UnitOfWork]
        public List<Menu> GetAll()
        {
            return menuRepository.GetAll().ToList();
        }

        [UnitOfWork]
        public List<Menu> GetMenus()
        {
            return menuRepository.GetMenus().ToList();
        }

        [UnitOfWork]
        public Menu GetById(int id)
        {
            return menuRepository.Get(id);
        }

        public object Insert(Menu menu)
        {
            return menuRepository.Insert(menu);
        }

        public void Update(Menu menu)
        {
            menuRepository.Update(menu);
        }

        public void Delete(int menuId)
        {
            menuRepository.Delete(menuId);
        }
    }
}