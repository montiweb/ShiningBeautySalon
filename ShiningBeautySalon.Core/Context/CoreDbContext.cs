using Microsoft.EntityFrameworkCore; 

namespace ShiningBeautySalon.Core.Context
{
    public class CoreDbContext : DbContext
    {
        protected CoreDbContext() { }
        protected CoreDbContext(DbContextOptions options) : base(options) { }
        protected CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options) { }
    }
}
