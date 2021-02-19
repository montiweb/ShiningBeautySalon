using ShiningBeautySalon.DAL.Context;
using ShiningBeautySalon.Core.Repository;

namespace ShiningBeautySalon.DAL.Repository
{
    public class GeneralRepository<T> : GenericRepository<T> where T : class
    {
        public GeneralRepository(ShiningContext serviceDeskDbContext) : base(serviceDeskDbContext) { }
    }
}
