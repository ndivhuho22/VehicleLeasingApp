using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLeasingApp.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

    }
}