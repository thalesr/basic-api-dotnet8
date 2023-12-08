using RestaurantManager.Model.Entities.Base;

namespace RestaurantManager.Model.Entities
{
    public class Address : BaseEntity
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Pincode { get; set; }
    }
}
