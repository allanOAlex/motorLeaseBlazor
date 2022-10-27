using ML.Data.Context;
using ML.Domain.Interfaces;
using ML.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ML.Data.Interfaces
{
    public class UserRepository : IBaseRepository<User>, IUserRepository
    {
        private readonly MLContext context;

        public UserRepository(MLContext Context)
        {
            context = Context;
        }

        public User Create(User entity)
        {
            context.Users.AddAsync(entity);
            return entity;
        }

        public void Delete(User entity)
        {
            context.Remove(entity);
        }

        public IQueryable<User> FindAll()
        {
            return context.Users;
        }

        public IQueryable<User> FindByCondition(Expression<Func<User, bool>> expression)
        {
            return context.Users.Where(expression);
        }

        public void Update(User entity)
        {
            context.Update(entity);
        }
    }
}
