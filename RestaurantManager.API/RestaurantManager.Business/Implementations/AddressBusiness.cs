using RestaurantManager.Business.Definitions;
using RestaurantManager.Business.Implementations.Base;
using RestaurantManager.Database.UOW;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.Business.Implementations
{
    public class AddressBusiness : GenericBusiness<Address>, IAddressBusiness
    {
        public AddressBusiness(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
