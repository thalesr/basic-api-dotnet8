using RestaurantManager.Model.Entities.Base;
using RestaurantManager.Model.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManager.Model.Entities
{
    public class Payment : BaseEntity
    {
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        public PaymentStatusEnum PaymentStatus { get; set; }
    }
}
