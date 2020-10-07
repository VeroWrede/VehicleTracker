using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace vehicleTracker 
{
    public class Vehicle 
    {
        [Key]
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        private string RegistrationNumber { get; set; }
    }
}
