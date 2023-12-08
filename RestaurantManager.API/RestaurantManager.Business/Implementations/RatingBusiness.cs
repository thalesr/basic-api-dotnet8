using RestaurantManager.Business.Definitions;
using RestaurantManager.Business.Implementations.Base;
using RestaurantManager.Database.UOW;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.Business.Implementations
{
    public class RatingBusiness : GenericBusiness<Rating>, IRatingBusiness
    {
        public RatingBusiness(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
