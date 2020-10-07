using System; 
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace vehicleTracker
{
    public class Address 
    {
        [Key]
        public int AddressId { get; set; }
        public string UnitNumber { get; set; }
        public int ApartmentNumber { get; set; }
    }
}