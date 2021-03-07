using System.Collections.Generic;

using ShiningBeautySalon.Core.Response;

namespace ShiningBeautySalon.Core.Service
{
    public interface IBaseService<TEntity>
    {
        Response<List<TEntity>> GetAll();
        Response<TEntity> GetByID(int ID);
        Response<TEntity> Add(TEntity model);
        Response<TEntity> Update(TEntity model);
        Response<TEntity> Delete(TEntity model);
    }
}
