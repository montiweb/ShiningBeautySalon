using System.Collections.Generic;
using ShiningBeautySalon.Core.Model;
using ShiningBeautySalon.Domain.Entities;

namespace ShiningBeautySalon.Service.Interfaces
{
    public interface ISalonService
    {
        IResponse<Salon> Add(Salon model);
        IResponse<Salon> Update(Salon model);
        IResponse<Salon> Delete(Salon model);
        IResponse<List<Salon>> GetAll();
        IResponse<Salon> GetByID(int salonId);
    }
}
