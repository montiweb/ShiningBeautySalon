using System.Collections.Generic;
using ShiningBeautySalon.Core.Model;
using ShiningBeautySalon.Domain.Entities;

namespace ShiningBeautySalon.Service.Interfaces
{
    public interface ILevelService
    {
        IResponse<Level> Add(Level model);
        IResponse<Level> Update(Level model);
        IResponse<Level> Delete(Level model);
        IResponse<List<Level>> GetAll();
        IResponse<Level> GetByID(int levelId);
    }
}
