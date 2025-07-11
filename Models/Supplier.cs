using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLeasingApp.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }

    }
}