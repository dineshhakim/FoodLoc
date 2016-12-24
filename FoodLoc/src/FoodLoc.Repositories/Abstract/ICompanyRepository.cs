using FoodLoc.Models.Entities;
using FoodLoc.Repositories.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodLoc.Repositories.Abstract
{
    public interface ICompanyRepository : IRepository<Company>
    {
    }
}
