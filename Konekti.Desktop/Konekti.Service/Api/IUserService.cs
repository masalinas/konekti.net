using System.Collections.Generic;
using Konekti.Model.Domain;

namespace Konekti.Service.Api
{
    public interface IUserService
    {
        List<User> GetAll();

        User GetById(int id);

        object Insert(User user);

        void Update(User user);

        void Delete(int userId);
    }
}
