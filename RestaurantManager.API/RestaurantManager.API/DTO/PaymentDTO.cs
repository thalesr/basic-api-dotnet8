using RestaurantManager.API.DTO.Base;
using RestaurantManager.Model.Enums;

namespace RestaurantManager.API.DTO
{
    public class CreatePaymentDTO : BaseCreateDTO
    {
        public int OrderID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatusEnum PaymentStatus { get; set; }
    }

    public class UpdatePaymentDTO : BaseUpdateDTO
    {
        public int OrderID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatusEnum PaymentStatus { get; set; }
    }

    public class PaymentDTO : BaseDTO
    {
        public int OrderID { get; set; }
        public OrderDTO Order { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatusEnum PaymentStatus { get; set; }
    }

}
