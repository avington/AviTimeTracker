using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using AviTimeTracker.Core.Context;

namespace AviTimeTracker.Core.Repositories
{
    public class GenericRepository<TEntity>
        where TEntity : class
    {
        internal ProjectContext Context;
        internal DbSet<TEntity> DbSet;

        public GenericRepository(ProjectContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedEnumerable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = DbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            query = includeProperties.Split(
                new[] {','}, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            return orderBy != null ? orderBy(query).ToList() : query.ToList();
        }

        public virtual TEntity GetByID(object id)
        {
            return DbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            Context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}