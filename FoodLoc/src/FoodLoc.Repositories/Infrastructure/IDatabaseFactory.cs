using System;

namespace FoodLoc.Repositories.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        DatabaseContext Get();
    }
}