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
        public DbSet<MechanicService> MechanicServices { get; set; }
        public DbSet<LogHistory> LogHistories { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
