using Microsoft.EntityFrameworkCore;
using ServiceBondhu.Models.Admin;
using ServiceBondhu.Models.User;

namespace ServiceBondhu.Data
{
    public class ServiceDbContext : DbContext
    {
        public ServiceDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ActionType> ActionTypes { get; set; }
        public DbSet<BookingServiceCompletion> BookingServiceCompletions { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }

        public DbSet<LogHistory> LogHistories { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Mechanic>()
       .HasOne(m => m.Service)
       .WithMany()
       .HasForeignKey(m => m.ServiceId)
       .OnDelete(DeleteBehavior.Restrict);

           
            modelBuilder.Entity<BookingServiceCompletion>()
                .HasOne(b => b.Mechanic)
                .WithMany()
                .HasForeignKey(b => b.MechanicId)
                .OnDelete(DeleteBehavior.Restrict);

         
            modelBuilder.Entity<BookingServiceCompletion>()
                .HasOne(b => b.Booking)
                .WithMany()
                .HasForeignKey(b => b.BookingId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<MechanicService>()
                .HasOne(ms => ms.Mechanic)
                .WithMany()
                .HasForeignKey(ms => ms.MechanicId)
                .OnDelete(DeleteBehavior.Restrict); 


            modelBuilder.Entity<MechanicService>()
                .HasOne(ms => ms.Service)
                .WithMany()
                .HasForeignKey(ms => ms.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
