using RestaurantManager.Model.Entities.Base;
using RestaurantManager.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
