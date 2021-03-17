using System.Linq;
using System.Collections.Generic;

using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using System.Threading.Tasks;

namespace ShiningBeautySalon.Service.Services
{
    public class SalonService : ISalonService
    {
        private readonly IUnitOfWork _shiningUnitOfWork;
        public SalonService(IUnitOfWork shiningUnitOfWork)
        {
            _shiningUnitOfWork = shiningUnitOfWork;
        }

        public IQueryable<Salon> GetAll()
        {
            return _shiningUnitOfWork.SalonRepository.GetAll(); 
        }

        public  Salon GetByID(int salonID)
        {
            return _shiningUnitOfWork.SalonRepository.Find(x => x.ID == salonID).FirstOrDefault(); 
        }

        public Salon Add(Salon model)
        {
            _shiningUnitOfWork.SalonRepository.Add(model);
            _shiningUnitOfWork.Commit();
            
            return model;
        }

        public Salon Update(Salon model)
        {
            _shiningUnitOfWork.SalonRepository.Update(model);
            _shiningUnitOfWork.Commit();
            
            return model;
        }

        public Salon Delete(Salon model)
        {
            _shiningUnitOfWork.SalonRepository.Remove(model);
            _shiningUnitOfWork.Commit();
            
            return model;
        }
    }
}
