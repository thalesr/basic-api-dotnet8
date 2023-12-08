using RestaurantManager.API.DTO.Base;
using RestaurantManager.Model.Enums;

namespace RestaurantManager.API.DTO
{
    public class CreateOrderDTO : BaseCreateDTO
    {
        public int UserID { get; set; }
        public int RestaurantID { get; set; }
        public decimal OrderTotal { get; set; }
        public DeliveryStatusEnum DeliveryStatus { get; set; }
        public int DriverID { get; set; }
    }

    public class UpdateOrderDTO : BaseUpdateDTO
    {
        public int UserID { get; set; }
        public int RestaurantID { get; set; }
        public decimal OrderTotal { get; set; }
        public DeliveryStatusEnum DeliveryStatus { get; set; }
        public int DriverID { get; set; }
    }

    public class OrderDTO : BaseDTO
    {
        public int UserID { get; set; }
        public UserDTO User { get; set; }
        public int RestaurantID { get; set; }
        public RestaurantDTO Restaurant { get; set; }
        public decimal OrderTotal { get; set; }
        public DeliveryStatusEnum DeliveryStatus { get; set; }
        public int DriverID { get; set; }
        public DriverDTO Driver { get; set; }
    }

}
