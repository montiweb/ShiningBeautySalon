using System;
using ShiningBeautySalon.DAL.Context;

namespace ShiningBeautySalon.DAL.UnitOfWork
{
    public partial class ShiningUnitOfWork
    {
        private readonly ShiningContext _shiningContext;
        private readonly IServiceProvider _serviceProvider;
        public ShiningUnitOfWork(ShiningContext context, IServiceProvider serviceProvider)
        {
            _shiningContext = context;
            _serviceProvider = serviceProvider;
        }
        public void Dispose() => _shiningContext.Dispose();
        public int SaveChanges() => _shiningContext.SaveChanges();
    }
}
