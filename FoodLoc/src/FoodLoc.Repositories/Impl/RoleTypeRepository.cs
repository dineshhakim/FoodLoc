using FoodLoc.Models.Entities;
using FoodLoc.Repositories.Abstract;
using FoodLoc.Repositories.Infrastructure;


namespace FoodLoc.Repositories.Impl
{
    public class RoleTypeRepository : RepositoryBase<RoleType>, IRoleTypeRepository
    {
        public RoleTypeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
    }
}
}
