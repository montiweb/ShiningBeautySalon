using System.Linq;
using System.Collections.Generic;
using ShiningBeautySalon.Core.Model;
using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;

namespace ShiningBeautySalon.Service.Services
{
    public class StaffService : IStaffService
    {
        private readonly ShiningUnitOfWork _shiningUnitOfWork;
        public StaffService(ShiningUnitOfWork shiningUnitOfWork)
        {
            _shiningUnitOfWork = shiningUnitOfWork;
        }

        public IResponse<Staff> Add(Staff model)
        {
            _shiningUnitOfWork.StaffRepository.Add(model);
            _shiningUnitOfWork.SaveChanges();
            return new Response<Staff>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public IResponse<Staff> Update(Staff model)
        {
            _shiningUnitOfWork.StaffRepository.Update(model);
            _shiningUnitOfWork.SaveChanges();
            return new Response<Staff>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public IResponse<Staff> Delete(Staff model)
        {
            _shiningUnitOfWork.StaffRepository.Remove(model);
            _shiningUnitOfWork.SaveChanges();
            return new Response<Staff>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public IResponse<List<Staff>> GetAll()
        {
            var response = _shiningUnitOfWork.StaffRepository.Get().ToList();
            return new Response<List<Staff>>
            {
                IsSuccessful = true,
                Result = response
            };
        }

        public IResponse<Staff> GetByID(int staffId)
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
