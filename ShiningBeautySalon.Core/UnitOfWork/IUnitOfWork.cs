using System; 

namespace ShiningBeautySalon.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }
}
