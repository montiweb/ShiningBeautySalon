using System;

using ShiningBeautySalon.DAL.Context;
using ShiningBeautySalon.Core.UnitOfWork;

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

        public void Commit() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
