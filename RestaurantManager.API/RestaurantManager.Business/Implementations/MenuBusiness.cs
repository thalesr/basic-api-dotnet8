using RestaurantManager.Business.Definitions;
using RestaurantManager.Business.Implementations.Base;
using RestaurantManager.Database.UOW;
using RestaurantManager.Model.Entities;

namespace RestaurantManager.Business.Implementations
{
    public class MenuBusiness : GenericBusiness<Menu>, IMenuBusiness
    {
        public MenuBusiness(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
