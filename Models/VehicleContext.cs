using Microsoft.EntityFrameworkCore;

namespace vehicleTracker.Models
{
    public class VehicleContext : DbContext{
        public VehicleContext(DbContextOptions options): base(options) {}
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}