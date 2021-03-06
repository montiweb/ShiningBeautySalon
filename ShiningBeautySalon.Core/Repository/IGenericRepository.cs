using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace ShiningBeautySalon.Core.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByID(object ID);
        IEnumerable<TEntity> Get(
           Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           string includeProperties = "");
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Update(object ID, TEntity entity);
        void Remove(TEntity entity);
        void Remove(object ID);
        void RemoveRange(IEnumerable<TEntity> entities);
        void Commit();
    }
}
