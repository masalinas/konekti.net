using System.Collections.Generic;
using System.Linq;

using Konekti.Framework.Data;
using Konekti.Model.Domain;
using Konekti.Repository.Api;
using Konekti.Service.Api;

namespace Konekti.Service.Impl
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }
        
        [UnitOfWork]
        public List<Role> GetAll()
        {
            /* Used UnitOfWork attribute, because GetAll method returns IQueryable<Person>, it does not fetches records from database. 
             * No database operation is performed until ToList(). Thus, we need to control connection open/close in this method using UnitOfWork. */
            return roleRepository.GetAll().ToList();
        }

        public object Insert(Role role)
        {
            /* Not used UnitOfWork attribute, because this method only calls one repository method and repository can manage it's connection/transaction. */
            return roleRepository.Insert(role);
        }

        public void Update(Role role)
        {
            /* Not used UnitOfWork attribute, because this method only calls one repository method and repository can manage it's connection/transaction. */
            roleRepository.Update(role);
        }

        public void Delete(int roleId)
        {
            roleRepository.Delete(roleId);
        }
    }
}