using System.Linq;
using System.Collections.Generic;
using ShiningBeautySalon.Core.Model;
using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;

namespace ShiningBeautySalon.Service.Services
{
    public class ServiceCategoryService : IServiceCategoryService
    {
        private readonly ShiningUnitOfWork _shiningUnitOfWork;
        public ServiceCategoryService(ShiningUnitOfWork shiningUnitOfWork)
        {
            _shiningUnitOfWork = shiningUnitOfWork;
        }
       
        public IResponse<ServiceCategory> Add(ServiceCategory model)
        {
            _shiningUnitOfWork.ServiceCategoryRepository.Add(model);
            _shiningUnitOfWork.SaveChanges();
            return new Response<ServiceCategory>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public IResponse<ServiceCategory> Update(ServiceCategory model)
        {
            _shiningUnitOfWork.ServiceCategoryRepository.Update(model);
            _shiningUnitOfWork.SaveChanges();
            return new Response<ServiceCategory>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public IResponse<ServiceCategory> Delete(ServiceCategory model)
        {
            _shiningUnitOfWork.ServiceCategoryRepository.Remove(model);
            _shiningUnitOfWork.SaveChanges();
            return new Response<ServiceCategory>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public IResponse<List<ServiceCategory>> GetAll()
        {
            var response = _shiningUnitOfWork.ServiceCategoryRepository.Get().ToList();
            return new Response<List<ServiceCategory>>
            {
                IsSuccessful = true,
                Result = response
            };
        }

        public IResponse<ServiceCategory> GetByID(int ServiceCategoryId)
        {
            var response = _shiningUnitOfWork.ServiceCategoryRepository.Find(x => x.ID == ServiceCategoryId).FirstOrDefault();
            return new Response<ServiceCategory>
            {
                IsSuccessful = true,
                Result = response
            };
        }
    }
}
