using System.Linq;
using System.Collections.Generic;
using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Domain.Entities;
using ShiningBeautySalon.Service.Interfaces;
using ShiningBeautySalon.Service.Response;

namespace ShiningBeautySalon.Service.Services
{
    public class LevelService : ILevelService
    {
        private readonly UnitOfWork _shiningUnitOfWork;
        public LevelService(UnitOfWork shiningUnitOfWork)
        {
            _shiningUnitOfWork = shiningUnitOfWork;
        }

        public Response<Level> Add(Level model)
        {
            _shiningUnitOfWork.LevelRepository.Add(model);
            _shiningUnitOfWork.Commit();
            return new Response<Level>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public Response<Level> Update(Level model)
        {
            _shiningUnitOfWork.LevelRepository.Update(model);
            _shiningUnitOfWork.Commit();
            return new Response<Level>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public Response<Level> Delete(Level model)
        {
            _shiningUnitOfWork.LevelRepository.Remove(model);
            _shiningUnitOfWork.Commit();
            return new Response<Level>
            {
                IsSuccessful = true,
                Result = model
            };
        }

        public Response<List<Level>> GetAll()
        {
            var response = _shiningUnitOfWork.LevelRepository.Get().ToList();
            return new Response<List<Level>>
            {
                IsSuccessful = true,
                Result = response
            };
        }

        public Response<Level> GetByID(int levelId)
        {
            var response = _shiningUnitOfWork.LevelRepository.Find(x => x.ID == levelId).FirstOrDefault();
            return new Response<Level>
            {
                IsSuccessful = true,
                Result = response
            };
        }
    }
}
