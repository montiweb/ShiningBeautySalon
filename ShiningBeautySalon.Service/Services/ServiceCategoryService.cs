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

        public async Task<List<ServiceCategory>> GetAll()
        {
            List<ServiceCategory> _levelList = new List<ServiceCategory>();

            await Task.Run(() =>
            {
                _levelList = _shiningUnitOfWork.ServiceCategoryRepository.Get().ToList();
            });

            return _levelList;
        }

        public async Task<ServiceCategory> GetByID(int ServiceCategoryID)
        {
            ServiceCategory _level = new ServiceCategory();

            await Task.Run(() =>
            {
                _level = _shiningUnitOfWork.ServiceCategoryRepository.Find(x => x.ID == ServiceCategoryID).FirstOrDefault();
            });

            return _level;
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
