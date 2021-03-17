using System;
using System.Threading.Tasks;
using ShiningBeautySalon.DAL.Context;

namespace ShiningBeautySalon.DAL.UnitOfWork
{
    public partial class UnitOfWork : IUnitOfWork
    {
        private readonly ShiningContext _context;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(ShiningContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }

        public async void Commit() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
