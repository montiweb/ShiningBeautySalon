
using System.Collections.Generic;
using ShiningBeautySalon.Core.Model;
using ShiningBeautySalon.Domain.Entities;

namespace ShiningBeautySalon.Service.Interfaces
{
    public interface IStaffService
    {
        IResponse<Staff> Add(Staff model);
        IResponse<Staff> Update(Staff model);
        IResponse<Staff> Delete(Staff model);
        IResponse<List<Staff>> GetAll();
        IResponse<Staff> GetByID(int staffId);
    }
}
