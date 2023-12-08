using RestaurantManager.API.DTO.Base;

namespace RestaurantManager.API.DTO
{
    public class CreateDriverDTO : BaseCreateDTO
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
    }

    public class UpdateDriverDTO : BaseUpdateDTO
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
    }

    public class DriverDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
    }

}
