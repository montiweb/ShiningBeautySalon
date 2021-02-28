using System.Linq;
using System.Collections.Generic;

using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using ShiningBeautySalon.Service.Response;

namespace ShiningBeautySalon.Service.Services
{
    public class StaffService : IStaffService
    {
        private readonly UnitOfWork _shiningUnitOfWork;
        public StaffService(UnitOfWork shiningUnitOfWork)
        {
            _shiningUnitOfWork = shiningUnitOfWork;
        }

        public Response<Staff> Add(Staff model)
        {
            _shiningUnitOfWork.StaffRepository.Add(model);
            _shiningUnitOfWork.Commit();
            return new Response<Staff>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public Response<Staff> Update(Staff model)
        {
            _shiningUnitOfWork.StaffRepository.Update(model);
            _shiningUnitOfWork.Commit();
            return new Response<Staff>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public Response<Staff> Delete(Staff model)
        {
            _shiningUnitOfWork.StaffRepository.Remove(model);
            _shiningUnitOfWork.Commit();
            return new Response<Staff>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public Response<List<Staff>> GetAll()
        {
            var response = _shiningUnitOfWork.StaffRepository.Get().ToList();
            return new Response<List<Staff>>
            {
                IsSuccessful = true,
                Result = response
            };
        }

        public Response<Staff> GetByID(int staffId)
        {
            var response = _shiningUnitOfWork.StaffRepository.Find(x => x.ID == staffId).FirstOrDefault();
            return new Response<Staff>
            {
                IsSuccessful = true,
                Result = response
            };
        }
    }
}
