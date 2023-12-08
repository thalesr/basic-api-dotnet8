using RestaurantManager.Model.Entities.Base;

namespace RestaurantManager.Model.Entities
{
    public class Driver : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
    }
}
