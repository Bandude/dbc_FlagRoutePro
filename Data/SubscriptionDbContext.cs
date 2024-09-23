using dbc_FlagRoutePro.Entities;
using Microsoft.EntityFrameworkCore;

namespace dbc_FlagRoutePro.Data
{


    
    public class SubscriptionDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<SubscriptionType> SubscriptionTypes { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<FlagRoute> FlagRoutes { get; set; }
        public DbSet<RouteStop> RouteStops { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }

        public DbSet<FlagSeason> FlagSeason { get; set; }
        public DbSet<FlagRouteDates> FlagRouteDates { get; set; }
        public SubscriptionDbContext(DbContextOptions<SubscriptionDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships and constraints
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Addresses)
                .WithOne(a => a.Customer)
                .HasForeignKey(a => a.CustomerId);
            modelBuilder.Entity<Address>()
                .HasMany(a => a.Subscriptions)
                .WithOne(s => s.Address)
                .HasForeignKey(s => s.AddressId);
            modelBuilder.Entity<SubscriptionType>()
                .HasMany(st => st.Subscriptions)
                .WithOne(s => s.SubscriptionType)
                .HasForeignKey(s => s.SubscriptionTypeId);
            modelBuilder.Entity<FlagRoute>()
                .HasMany(fr => fr.Stops)
                .WithOne(rs => rs.FlagRoute)
                .HasForeignKey(rs => rs.FlagRouteId);
            modelBuilder.Entity<RouteStop>()
                .HasOne(rs => rs.Subscription)
                .WithMany()
                .HasForeignKey(rs => rs.SubscriptionId);
            //TODO: Add all the relationships
        }
    }


}
