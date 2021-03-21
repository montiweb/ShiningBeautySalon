using System.Threading.Tasks;
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
        public Level Save(Level Entity)
        {
            _shiningUnitOfWork.LevelRepository.Save(Entity);
            _shiningUnitOfWork.Commit();

            return Entity;
        }
        public async Task<int> SaveAsync(Level Entity)
        {
            _shiningUnitOfWork.LevelRepository.Save(Entity);
            return await _shiningUnitOfWork.CommitAsync();
        }
        public Level Delete(Level Entity)
        {
            _shiningUnitOfWork.LevelRepository.Remove(Entity);
            _shiningUnitOfWork.Commit();

            return Entity;
        }
    }
}
