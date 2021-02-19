using ShiningBeautySalon.Core.Repository;
using ShiningBeautySalon.Core.UnitOfWork;
using ShiningBeautySalon.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ShiningBeautySalon.DAL.UnitOfWork
{
    public partial class ShiningUnitOfWork : IUnitOfWork
    {
        #region Repositories
        public IGenericRepository<Level> LevelRepository => _serviceProvider.GetService<IGenericRepository<Level>>();
        public IGenericRepository<Salon> SalonRepository => _serviceProvider.GetService<IGenericRepository<Salon>>();
        public IGenericRepository<Staff> StaffRepository => _serviceProvider.GetService<IGenericRepository<Staff>>();
        public IGenericRepository<ServiceCategory> ServiceCategoryRepository => _serviceProvider.GetService<IGenericRepository<ServiceCategory>>();
        #endregion
    }
}
