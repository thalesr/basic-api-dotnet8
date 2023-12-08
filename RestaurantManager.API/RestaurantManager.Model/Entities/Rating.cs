using RestaurantManager.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model.Entities
{
    public class Rating : BaseEntity
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int RestaurantID { get; set; }
        public Restaurant Restaurant { get; set; }
        public int RatingValue { get; set; }
    }
}
