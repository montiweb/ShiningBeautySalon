using System.Linq;
using System.Collections.Generic;
using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using System.Threading.Tasks;

namespace ShiningBeautySalon.Service.Services
{
    public class LevelService : ILevelService
    {
        private readonly IUnitOfWork _shiningUnitOfWork;
        public LevelService(IUnitOfWork shiningUnitOfWork)
        {
            _shiningUnitOfWork = shiningUnitOfWork;
        }
        public async Task<List<Level>> GetAll()
        {
            List<Level> _levelList = new List<Level>();

            await Task.Run(() =>
            {
                _levelList = _shiningUnitOfWork.LevelRepository.Get().ToList();
            });
            
            return _levelList;
        }

        public async Task<Level> GetByID(int levelID)
        {
            Level _level = new Level();

            await Task.Run(() =>
            {
                _level = _shiningUnitOfWork.LevelRepository.Find(x => x.ID == levelID).FirstOrDefault();
            });

            return _level;
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
