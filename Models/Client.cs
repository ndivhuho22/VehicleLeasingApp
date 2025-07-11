﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLeasingApp.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson {  get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }

    }
}