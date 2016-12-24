﻿using Microsoft.AspNetCore.Server.Kestrel;

namespace FoodLoc.Repositories.Infrastructure
{
   public class DatabaseFactory: Disposable, IDatabaseFactory
    {
        private DatabaseContext dataContext;
        public DatabaseContext Get()
        {
            return dataContext ?? (dataContext = new DatabaseContext());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
    
}
