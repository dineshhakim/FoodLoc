﻿using FoodLoc.Models.Entities;
using FoodLoc.Repositories.Abstract;
using FoodLoc.Repositories.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodLoc.Repositories.Impl
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }


    }
}
