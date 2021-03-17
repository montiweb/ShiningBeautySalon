using System.Collections.Generic;

namespace ShiningBeautySalon.Core.Service
{
    public interface IBaseService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByID(int ID);
        TEntity Save(TEntity model);
        TEntity Add(TEntity model);
        TEntity Update(TEntity model);
        TEntity Delete(TEntity model);
    }
}
