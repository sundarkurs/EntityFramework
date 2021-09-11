
using CodeFirst.Core.Repository;
using CodeFirst.Models;

namespace CodeFirst.Persistence.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(UserManagementContext context) : base(context)
        {
        }

        public UserManagementContext UserContext
        {
            get { return Context as UserManagementContext; }
        }
    }
}
