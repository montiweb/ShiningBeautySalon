using System.Collections.Generic;
using ShiningBeautySalon.Core.Model;

namespace ShiningBeautySalon.Service.Interfaces
{
    public interface IBaseService<T>
    {
        IResponse<List<T>> GetAll();
        IResponse<T> GetByID(int ID);
        IResponse<T> Add(T model);
        IResponse<T> Update(T model);
        IResponse<T> Delete(T model);
    }
}
