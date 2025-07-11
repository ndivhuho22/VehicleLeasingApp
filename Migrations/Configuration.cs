namespace VehicleLeasingApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VehicleLeasingApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VehicleLeasingApp.Data.VehicleLeasingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VehicleLeasingApp.Data.VehicleLeasingContext context)
        {
            // Add sample suppliers
            var suppliers = new[]
            {
                new Supplier { Name = "Toyota", Address = "123 Toyota Street" },
                new Supplier { Name = "Ford", Address = "456 Ford Avenue" },
                new Supplier { Name = "Honda", Address = "789 Honda Boulevard" }
            };
            context.Suppliers.AddOrUpdate(s => s.Name, suppliers);

            // Add sample branches
            var branches = new[]
            {
                new Branch { Name = "Main Branch", Location = "123 Main Street" },
                new Branch { Name = "Downtown Branch", Location = "456 Downtown Avenue" },
                new Branch { Name = "Suburban Branch", Location = "789 Suburban Boulevard" }
            };
            context.Branches.AddOrUpdate(b => b.Name, branches);

            // Add sample clients
            var clients = new[]
            {
                new Client { CompanyName = "ABC Corporation", ContactPerson = "John Doe" },
                new Client { CompanyName = "XYZ Inc.", ContactPerson = "Jane Smith" },
                new Client { CompanyName = "DEF Limited", ContactPerson = "Bob Johnson" }
            };
            context.Clients.AddOrUpdate(c => c.CompanyName, clients);

            // Add sample drivers
            var drivers = new[]
            {
                new Driver { FullName = "John Smith", LicenseNumber = "ABC123" },
                new Driver { FullName = "Jane Doe", LicenseNumber = "XYZ456" },
                new Driver { FullName = "Bob Johnson", LicenseNumber = "DEF789" }
            };
            context.Drivers.AddOrUpdate(d => d.FullName, drivers);

            // Add sample vehicles
            var vehicles = new[]
            {
                new Vehicle { Manufacturer = "Toyota", Model = "Corolla", SupplierId = 1, BranchId = 1, ClientId = 1, DriverId = 1 },
                new Vehicle { Manufacturer = "Ford", Model = "Focus", SupplierId = 2, BranchId = 2, ClientId = 2, DriverId = 2 },
                new Vehicle { Manufacturer = "Honda", Model = "Civic", SupplierId = 3, BranchId = 3, ClientId = 3,DriverId = 2 }
            };
            context.Vehicles.AddOrUpdate(v => v.Model, vehicles);

            context.SaveChanges();
        }
    }
}
