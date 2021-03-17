using System.Linq;
using System.Collections.Generic;

using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using System.Threading.Tasks;

namespace ShiningBeautySalon.Service.Services
{
    public class ServiceCategoryService : IServiceCategoryService
    {
        private readonly IUnitOfWork _shiningUnitOfWork;
        public ServiceCategoryService(IUnitOfWork shiningUnitOfWork)
        {
            _shiningUnitOfWork = shiningUnitOfWork;
        }

        public IQueryable<ServiceCategory> GetAll()
        {
            return _shiningUnitOfWork.ServiceCategoryRepository.GetAll();
        }

        public ServiceCategory GetByID(int ServiceCategoryID)
        {
            return _shiningUnitOfWork.ServiceCategoryRepository.Find(x => x.ID == ServiceCategoryID).FirstOrDefault();
        }

        public ServiceCategory Add(ServiceCategory model)
        {
            _shiningUnitOfWork.ServiceCategoryRepository.Add(model);
            _shiningUnitOfWork.Commit();
            
            return model;
        }

        public ServiceCategory Update(ServiceCategory model)
        {
            _shiningUnitOfWork.ServiceCategoryRepository.Update(model);
            _shiningUnitOfWork.Commit();
            
            return model;
        }

        public ServiceCategory Delete(ServiceCategory model)
        {
            _shiningUnitOfWork.ServiceCategoryRepository.Remove(model);
            _shiningUnitOfWork.Commit();
            
            return model;
        }
     
    }
}
