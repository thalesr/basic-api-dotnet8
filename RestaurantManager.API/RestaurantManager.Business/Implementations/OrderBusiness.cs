using RestaurantManager.Business.Definitions;
using RestaurantManager.Business.Implementations.Base;
using RestaurantManager.Database.UOW;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.Business.Implementations
{
    public class OrderBusiness : GenericBusiness<Order>, IOrderBusiness
    {
        public OrderBusiness(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
