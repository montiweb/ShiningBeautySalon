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

        public async Task<List<Staff>> GetAll()
        {
            List<Staff> _levelList = new List<Staff>();

            await Task.Run(() =>
            {
                _levelList = _shiningUnitOfWork.StaffRepository.Get().ToList();
            });

            return _levelList;
        }
      
        public async Task<Staff> GetByID(int staffID)
        {
            Staff _level = new Staff();

            await Task.Run(() =>
            {
                _level = _shiningUnitOfWork.StaffRepository.Find(x => x.ID == staffID).FirstOrDefault();
            });

            return _level;
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
