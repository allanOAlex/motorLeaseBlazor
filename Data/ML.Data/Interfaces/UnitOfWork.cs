using Microsoft.EntityFrameworkCore;
using ML.Data.Context;
using ML.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ML.Data.Interfaces
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MLContext context;
        public IUserRepository Users { get; private set; }
        public IBookingRepository Bookings { get; private set; }

        public UnitOfWork(MLContext Context)
        {
            context = Context;

            Users = new UserRepository(context);
            Bookings = new BookingRepository(context);
        }


        public Task CompleteAsync()
        {
            return context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
    }
}
