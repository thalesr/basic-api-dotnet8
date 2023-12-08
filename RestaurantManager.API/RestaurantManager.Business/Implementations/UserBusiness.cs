using RestaurantManager.Business.Definitions;
using RestaurantManager.Business.Implementations.Base;
using RestaurantManager.Database.UOW;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.Business.Implementations
{
    public class UserBusiness : GenericBusiness<User>, IUserBusiness
    {
        public UserBusiness(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
