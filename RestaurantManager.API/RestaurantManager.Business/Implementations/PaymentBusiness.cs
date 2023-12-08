using RestaurantManager.Business.Definitions;
using RestaurantManager.Business.Implementations.Base;
using RestaurantManager.Database.UOW;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.Business.Implementations
{
    public class PaymentBusiness : GenericBusiness<Payment>, IPaymentBusiness
    {
        public PaymentBusiness(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
