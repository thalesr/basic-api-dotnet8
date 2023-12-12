using RestaurantManager.Business.Definitions.Base;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.Business.Definitions
{
    public interface IOrderBusiness : IGenericBusiness<Order>
    {
        Task<List<Order>> GetByUserId(int userId);
    }
}
