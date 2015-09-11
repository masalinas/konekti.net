using System.Collections.Generic;
using Konekti.Model.Domain;

namespace Konekti.Service.Api
{
    public interface IRoleService
    {
        List<Role> GetAll();

        object Insert(Role role);

        void Update(Role role);

        void Delete(int roleId);
    }
}
