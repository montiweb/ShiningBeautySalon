using System.Collections.Generic;

using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;

namespace ShiningBeautySalon.Service.Services
{
    public class LevelService : ILevelService
    {
        private readonly IUnitOfWork _shiningUnitOfWork;
        public LevelService(IUnitOfWork shiningUnitOfWork)
        {
            _shiningUnitOfWork = shiningUnitOfWork;
        }

        public IEnumerable<Level> GetAll()
        {
            return _shiningUnitOfWork.LevelRepository.GetAll();
        }
        public Level GetByID(int ID)
        {
            return _shiningUnitOfWork.LevelRepository.Find(x => x.ID == ID).Result;
        }
        public Level Save(Level model)
        {
            _shiningUnitOfWork.LevelRepository.Save(model);
            _shiningUnitOfWork.Commit();

            return model;
        }
        public Level Add(Level model)
        {
            _shiningUnitOfWork.LevelRepository.Add(model);
            _shiningUnitOfWork.Commit();

            return model;
        }
        public Level Update(Level model)
        {
            _shiningUnitOfWork.LevelRepository.Update(model);
            _shiningUnitOfWork.Commit();

            return model;
        }
        public Level Delete(Level model)
        {
            _shiningUnitOfWork.LevelRepository.Remove(model);
            _shiningUnitOfWork.Commit();

            return model;
        }
    }
}
