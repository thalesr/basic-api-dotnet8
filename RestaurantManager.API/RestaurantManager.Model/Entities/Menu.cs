using RestaurantManager.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model.Entities
{
    public class Menu : BaseEntity
    {
        public int RestaurantID { get; set; }
        public Restaurant Restaurant { get; set; }
        public string ItemName { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}
