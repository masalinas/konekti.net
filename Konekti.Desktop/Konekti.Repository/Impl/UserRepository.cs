using Konekti.Repository.Api;
using Konekti.Model.Domain;
using Konekti.Repository.Data;

namespace Konekti.Repository.Impl
{
    public class UserRepository : NhRepositoryBase<User, int>, IUserRepository
    {
    }
}