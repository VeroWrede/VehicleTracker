using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace vehicleTracker {
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
    }
}