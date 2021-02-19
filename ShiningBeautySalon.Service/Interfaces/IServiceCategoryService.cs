using System.Collections.Generic;
using ShiningBeautySalon.Core.Model;
using ShiningBeautySalon.Domain.Entities;

namespace ShiningBeautySalon.Service.Interfaces
{
    public interface IServiceCategoryService
    {
        IResponse<ServiceCategory> Add(ServiceCategory model);
        IResponse<ServiceCategory> Update(ServiceCategory model);
        IResponse<ServiceCategory> Delete(ServiceCategory model);
        IResponse<List<ServiceCategory>> GetAll();
        IResponse<ServiceCategory> GetByID(int serviceCategoryId);
    }
}
