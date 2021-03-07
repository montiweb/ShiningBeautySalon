using System.Linq;
using System.Collections.Generic;

using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Core.Response;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;

namespace ShiningBeautySalon.Service.Services
{
    public class ServiceCategoryService : IServiceCategoryService
    {
        private readonly UnitOfWork _shiningUnitOfWork;
        public ServiceCategoryService(UnitOfWork shiningUnitOfWork)
        {
            _shiningUnitOfWork = shiningUnitOfWork;
        }

        public Response<List<ServiceCategory>> GetAll()
        {
            var response = _shiningUnitOfWork.ServiceCategoryRepository.Get().ToList();
            return new Response<List<ServiceCategory>>
            {
                IsSuccessful = true,
                Result = response
            };
        }

        public Response<ServiceCategory> GetByID(int ServiceCategoryID)
        {
            var response = _shiningUnitOfWork.ServiceCategoryRepository.Find(x => x.ID == ServiceCategoryID).FirstOrDefault();
            return new Response<ServiceCategory>
            {
                IsSuccessful = true,
                Result = response
            };
        }

        public Response<ServiceCategory> Add(ServiceCategory model)
        {
            _shiningUnitOfWork.ServiceCategoryRepository.Add(model);
            _shiningUnitOfWork.Commit();
            return new Response<ServiceCategory>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public Response<ServiceCategory> Update(ServiceCategory model)
        {
            _shiningUnitOfWork.ServiceCategoryRepository.Update(model);
            _shiningUnitOfWork.Commit();
            return new Response<ServiceCategory>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public Response<ServiceCategory> Delete(ServiceCategory model)
        {
            _shiningUnitOfWork.ServiceCategoryRepository.Remove(model);
            _shiningUnitOfWork.Commit();
            return new Response<ServiceCategory>
            {
                IsSuccessful = true,
                Result = model
            };
        }
     
    }
}
