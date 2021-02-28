using System.Linq;
using System.Collections.Generic;

using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using ShiningBeautySalon.Service.Response;

namespace ShiningBeautySalon.Service.Services
{
    public class SalonService : ISalonService
    {
        private readonly UnitOfWork _shiningUnitOfWork;
        public SalonService(UnitOfWork shiningUnitOfWork)
        {
            _shiningUnitOfWork = shiningUnitOfWork;
        }

        public Response<Salon> Add(Salon model)
        {
            _shiningUnitOfWork.SalonRepository.Add(model);
            _shiningUnitOfWork.Commit();
            return new Response<Salon>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public Response<Salon> Update(Salon model)
        {
            _shiningUnitOfWork.SalonRepository.Update(model);
            _shiningUnitOfWork.Commit();
            return new Response<Salon>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public Response<Salon> Delete(Salon model)
        {
            _shiningUnitOfWork.SalonRepository.Remove(model);
            _shiningUnitOfWork.Commit();
            return new Response<Salon>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public Response<List<Salon>> GetAll()
        {
            var response = _shiningUnitOfWork.SalonRepository.Get().ToList();
            return new Response<List<Salon>>
            {
                IsSuccessful = true,
                Result = response
            };
        }

        public Response<Salon> GetByID(int salonId)
        {
            var response = _shiningUnitOfWork.SalonRepository.Find(x => x.ID == salonId).FirstOrDefault();
            return new Response<Salon>
            {
                IsSuccessful = true,
                Result = response
            };
        }
    }
}
