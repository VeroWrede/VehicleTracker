using System; 
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace vehicleTracker
{
    public class Address 
    {
        [Key]
        public int AddressId { get; set; }
        [Required(ErrorMessage = "Unit Number is required")]
        [Display(Name = "Unit Number")]
        public string UnitNumber { get; set; }
        [Required(ErrorMessage = "Apartment Number is required")]
        [Display(Name = "Apartment Number")]
        public int ApartmentNumber { get; set; }

        public ICollection<AddressOwner> AddressOwners { get; set;}
    }
}