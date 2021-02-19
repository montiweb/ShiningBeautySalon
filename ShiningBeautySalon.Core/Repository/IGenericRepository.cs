using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace ShiningBeautySalon.Core.Repository
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> Get(
           Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           string includeProperties = "");

        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entityToUpdate);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void RemoveEntity(TEntity entityToDelete);
    }
}
