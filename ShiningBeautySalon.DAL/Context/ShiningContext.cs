using Microsoft.EntityFrameworkCore;
using ShiningBeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShiningBeautySalon.DAL.Context
{
    public class ShiningContext : DbContext
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
