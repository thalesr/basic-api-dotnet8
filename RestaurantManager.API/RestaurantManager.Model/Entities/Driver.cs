using RestaurantManager.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model.Entities
{
    public class Driver : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
    }
}
