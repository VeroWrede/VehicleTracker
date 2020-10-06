namespace vehicleTracker
{
    public class AddressOwner 
    {
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}