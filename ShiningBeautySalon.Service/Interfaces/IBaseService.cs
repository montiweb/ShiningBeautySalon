using ShiningBeautySalon.Service.Response;
using System.Collections.Generic;

namespace ShiningBeautySalon.Service.Interfaces
{
    public interface IBaseService<T>
    {
        Response<List<T>> GetAll();
        Response<T> GetByID(int ID);
        Response<T> Add(T model);
        Response<T> Update(T model);
        Response<T> Delete(T model);
    }
}
