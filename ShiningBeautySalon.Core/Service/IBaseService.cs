using System.Collections.Generic;

namespace ShiningBeautySalon.Core.Service
{
    public interface IBaseService<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetByID(int ID);
        TEntity Add(TEntity model);
        TEntity Update(TEntity model);
        TEntity Delete(TEntity model);
    }
}
