using System;
using System.Threading.Tasks;
using ShiningBeautySalon.Core.Repository;
using ShiningBeautySalon.Domain.Entities;

namespace ShiningBeautySalon.DAL.UnitOfWork
{
    public interface IUnitOfWork //: IDisposable
    {
        IGenericRepository<Level> LevelRepository { get; }
        IGenericRepository<Salon> SalonRepository { get; }
        IGenericRepository<Staff> StaffRepository { get; }
        IGenericRepository<ServiceCategory> ServiceCategoryRepository { get; }
        int Commit();
        Task<int> CommitAsync();
    }
}
