using FoodLoc.Models.Entities;

namespace FoodLoc.Services.Abstract
{
    public interface IUserService : IServiceCommand<User>
    {
        bool CheckLogin(User user);
    }
}