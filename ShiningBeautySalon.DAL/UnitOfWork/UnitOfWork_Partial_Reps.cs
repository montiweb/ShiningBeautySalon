using Microsoft.Extensions.DependencyInjection;

using ShiningBeautySalon.Core.Repository;
using ShiningBeautySalon.Domain.Entities;

namespace ShiningBeautySalon.DAL.UnitOfWork
{
    public partial class UnitOfWork
    {
        public IGenericRepository<Level> LevelRepository => _serviceProvider.GetService<IGenericRepository<Level>>();
        public IGenericRepository<Salon> SalonRepository => _serviceProvider.GetService<IGenericRepository<Salon>>();
        public IGenericRepository<Staff> StaffRepository => _serviceProvider.GetService<IGenericRepository<Staff>>();
        public IGenericRepository<ServiceCategory> ServiceCategoryRepository => _serviceProvider.GetService<IGenericRepository<ServiceCategory>>();
    }
}
