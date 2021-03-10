using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShiningBeautySalon.Core.Service
{
    public interface IBaseService<TEntity>
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetByID(int ID);
        TEntity Add(TEntity model);
        TEntity Update(TEntity model);
        TEntity Delete(TEntity model);
    }
}
