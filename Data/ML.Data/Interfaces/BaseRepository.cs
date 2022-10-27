using Microsoft.EntityFrameworkCore;
using ML.Data.Context;
using ML.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ML.Data.Interfaces
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected MLContext context;
        internal DbSet<T> dbSet;

        public BaseRepository(MLContext Context)
        {
            context = Context;
            dbSet = context.Set<T>();
        }

        public T Create(T entity)
        {
            context.Set<T>().Add(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }
    }
}
