using System.Collections.Generic;
using System.Linq;

using Konekti.Framework.Data;
using Konekti.Model.Domain;
using Konekti.Repository.Api;
using Konekti.Service.Api;

namespace Konekti.Service.Impl
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        
        [UnitOfWork]
        public List<User> GetAll()
        {
            /* Used UnitOfWork attribute, because GetAll method returns IQueryable<Person>, it does not fetches records from database. 
             * No database operation is performed until ToList(). Thus, we need to control connection open/close in this method using UnitOfWork. */
            return userRepository.GetAll().OrderBy(menuGroup => menuGroup.Name).ToList();
        }

        [UnitOfWork]
        public User GetById(int id)
        {
            /* Used UnitOfWork attribute, because GetAll method returns IQueryable<Person>, it does not fetches records from database. 
             * No database operation is performed until ToList(). Thus, we need to control connection open/close in this method using UnitOfWork. */
            return userRepository.Get(id);
        }

        public object Insert(User user)
        {
            /* Not used UnitOfWork attribute, because this method only calls one repository method and repository can manage it's connection/transaction. */
            return userRepository.Insert(user);
        }

        public void Update(User user)
        {
            /* Not used UnitOfWork attribute, because this method only calls one repository method and repository can manage it's connection/transaction. */
            userRepository.Update(user);
        }

        public void Delete(int userId)
        {
            userRepository.Delete(userId);
        }
    }
}