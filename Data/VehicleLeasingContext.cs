using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VehicleLeasingApp.Models;

namespace VehicleLeasingApp.Data
{
    public class VehicleLeasingContext : DbContext
    {
        public VehicleLeasingContext() : base("VehicleLeasingDb") { }


        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

    }
}