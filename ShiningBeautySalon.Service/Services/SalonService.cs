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

        public async Task<List<Salon>> GetAll()
        {
            List<Salon> _levelList = new List<Salon>();

            await Task.Run(() =>
            {
                _levelList = _shiningUnitOfWork.SalonRepository.Get().ToList();
            });

            return _levelList;
        }

        public async Task<Salon> GetByID(int salonID)
        {
            Salon _level = new Salon();

            await Task.Run(() =>
            {
                _level = _shiningUnitOfWork.SalonRepository.Find(x => x.ID == salonID).FirstOrDefault();
            });

            return _level;
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
