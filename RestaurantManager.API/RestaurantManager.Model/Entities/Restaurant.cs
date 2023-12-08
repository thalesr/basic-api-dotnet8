using RestaurantManager.Model.Entities.Base;

namespace RestaurantManager.Model.Entities
{
    public class Restaurant : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
