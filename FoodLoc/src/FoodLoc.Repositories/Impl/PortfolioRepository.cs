using FoodLoc.Models.Entities;
using FoodLoc.Repositories.Abstract;
using FoodLoc.Repositories.Infrastructure;

namespace FoodLoc.Repositories.Impl
{
    public class PortfolioRepository : RepositoryBase<Portfolio>, IPortfolioRepository
    {
        public PortfolioRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }

       
    }
}
