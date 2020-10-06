using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace vehicleTracker {
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = " Phone Number")]
        public int PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatetAt { get; set; } = DateTime.Now;

        public ICollection<VehicleOwner> VehicleOwners { get; set; }
        public ICollection<AddressOwner> AddressOwners { get; set; }
    }
}