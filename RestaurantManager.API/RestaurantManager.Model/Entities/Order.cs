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
    public class Order : BaseEntity
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int RestaurantID { get; set; }
        public Restaurant Restaurant { get; set; }
        [Column(TypeName = "money")]
        public decimal OrderTotal { get; set; }
        public DeliveryStatusEnum DeliveryStatus { get; set; }
        public int DriverID { get; set; }
        public Driver Driver { get; set; }
    }
}
