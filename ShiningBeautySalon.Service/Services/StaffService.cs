using System.Linq;
using System.Collections.Generic;

using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using System.Threading.Tasks;

namespace ShiningBeautySalon.Service.Services
{
    public class StaffService : IStaffService
    {
        private readonly IUnitOfWork _shiningUnitOfWork;
        public StaffService(IUnitOfWork shiningUnitOfWork)
        {
            _shiningUnitOfWork = shiningUnitOfWork;
        }

        public List<Staff> GetAll()
        {
            return _shiningUnitOfWork.StaffRepository.GetAll().ToList();
        }
      
        public Staff GetByID(int staffID)
        {
            return _shiningUnitOfWork.StaffRepository.Find(x => x.ID == staffID).FirstOrDefault();
        }

        public Staff Add(Staff model)
        {
            _shiningUnitOfWork.StaffRepository.Add(model);
            _shiningUnitOfWork.Commit();
           
            return model;
        }

        public Staff Update(Staff model)
        {
            _shiningUnitOfWork.StaffRepository.Update(model);
            _shiningUnitOfWork.Commit();
            
            return model;
        }

        public Staff Delete(Staff model)
        {
            _shiningUnitOfWork.StaffRepository.Remove(model);
            _shiningUnitOfWork.Commit();
            
            return model;
        }

       
    }
}
