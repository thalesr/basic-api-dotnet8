using RestaurantManager.API.DTO.Base;

namespace RestaurantManager.API.DTO
{
    public class CreateMenuDTO : BaseCreateDTO
    {
        public int RestaurantID { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
    }

    public class UpdateMenuDTO : BaseUpdateDTO
    {
        public int RestaurantID { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
    }

    public class MenuDTO : BaseDTO
    {
        public int RestaurantID { get; set; }
        public RestaurantDTO Restaurant { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
    }

}
