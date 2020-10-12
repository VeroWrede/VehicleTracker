using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace vehicleTracker 
{
    public class Vehicle 
    {
        [Key]
        public int VehicleId { get; set; }
        [Required(ErrorMessage = "Vehicle Make is required")]
        [Display(Name = "Vehicle Make")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Vehicle Model is requred")]
        [Display(Name = "Vehicle Model")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Vehicle Color is required")]
        [Display(Name = "Vehicle Color")]
        public string Color { get; set; }
        public string Registration_number { get; set; }
        // public ICollection<VehicleOwner> VehicleOwners { get; set; }
    }
}
