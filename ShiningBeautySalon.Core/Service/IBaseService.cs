using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShiningBeautySalon.Core.Service
{
    public interface IBaseService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByID(int ID);
        TEntity Save(TEntity model);
        Task<int> SaveAsync(TEntity model);
        TEntity Delete(TEntity model);
    }
}
