using RestaurantManager.Business.Definitions;
using RestaurantManager.Business.Implementations.Base;
using RestaurantManager.Database.UOW;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.Business.Implementations
{
    public class DriverBusiness : GenericBusiness<Driver>, IDriverBusiness
    {
        public DriverBusiness(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
