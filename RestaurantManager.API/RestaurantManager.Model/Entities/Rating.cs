using RestaurantManager.Model.Entities.Base;

namespace RestaurantManager.Model.Entities
{
    public class Rating : BaseEntity
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int RestaurantID { get; set; }
        public Restaurant Restaurant { get; set; }
        public int RatingValue { get; set; }
    }
}
