using Microsoft.EntityFrameworkCore;
using ShiningBeautySalon.Core.Context; 
using ShiningBeautySalon.Domain.Entities;

namespace ShiningBeautySalon.DAL.Context
{
    public class ShiningContext : CoreDbContext
    {
        public ShiningContext()
        {
        }
        public ShiningContext(DbContextOptions<ShiningContext> options)
              : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
