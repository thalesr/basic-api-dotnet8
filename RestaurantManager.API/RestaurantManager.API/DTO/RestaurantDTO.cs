using RestaurantManager.API.DTO.Base;

namespace RestaurantManager.API.DTO
{

    public class CreateRestaurantDTO : BaseCreateDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

    public class UpdateRestaurantDTO : BaseUpdateDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

    public class RestaurantDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

}
