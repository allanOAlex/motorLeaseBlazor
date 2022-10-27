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
    public class BookingRepository : IBaseRepository<Booking>, IBookingRepository
    {
        private readonly MLContext context;

        public BookingRepository(MLContext Context)
        {
            context = Context;
        }

        public Booking Create(Booking entity)
        {
            context.Bookings.AddAsync(entity);
            return entity;
        }

        public void Delete(Booking entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Booking> FindAll()
        {
            return context.Bookings;
        }

        public IQueryable<Booking> FindByCondition(Expression<Func<Booking, bool>> expression)
        {
            return context.Bookings.Where(expression);
        }

        public void Update(Booking entity)
        {
            context.Update(entity);
        }
    }
}
