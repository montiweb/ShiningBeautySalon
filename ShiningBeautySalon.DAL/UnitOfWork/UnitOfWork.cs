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

        public int Commit()
        {
            try
            {
                return _context.SaveChanges();

            }
            catch (Exception exp)
            {
                return 2;
            }
        }

        public async Task<int> CommitAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return 2;
            }

        }

        //private bool disposed = false;
        //protected virtual void Dispose(bool disposing)
        //{
        //    try
        //    {
        //        if (!disposed)
        //        {
        //            if (disposing)
        //            {
        //                _context.Dispose();
        //            }
        //        }
        //        disposed = true;
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
        //public void Dispose()
        //{
        //    _context.Dispose();
        //}
    }
}
