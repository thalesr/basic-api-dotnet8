using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Order>> GetByUserId(int userId)
        {
            return await Repository.GetAll(expression: query => query.UserID == userId,
                                           include: include => include.Include(x => x.Restaurant)
                                                                      .Include(x => x.Driver),
                                           orderBy: orderBy => orderBy.OrderByDescending(x => x.Date));
        }

    }
}
