using RestaurantManager.API.DTO.Base;

namespace RestaurantManager.API.DTO
{
    public class CreateRatingDTO : BaseCreateDTO
    {
        public int UserID { get; set; }
        public int RestaurantID { get; set; }
        public int RatingValue { get; set; }
    }

    public class UpdateRatingDTO : BaseUpdateDTO
    {
        public int UserID { get; set; }
        public int RestaurantID { get; set; }
        public int RatingValue { get; set; }
    }

    public class RatingDTO : BaseDTO
    {
        public int UserID { get; set; }
        public UserDTO User { get; set; }
        public int RestaurantID { get; set; }
        public RestaurantDTO Restaurant { get; set; }
        public int RatingValue { get; set; }
    }

}
