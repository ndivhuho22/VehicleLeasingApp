using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLeasingApp.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }

    }
}