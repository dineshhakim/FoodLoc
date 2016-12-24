using FoodLoc.Models.Entities;
using FoodLoc.Repositories.Abstract;
using FoodLoc.Repositories.Infrastructure;

namespace FoodLoc.Repositories.Impl
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
