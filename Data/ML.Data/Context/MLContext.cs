using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ML.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Data.Context
{
    public class MLContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MLContext(DbContextOptions<MLContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer(Configuration.GetConnectionString("ML"));
        //}

        public DbSet<MotorType> MotorTypes { get; set; }
        public DbSet<MotorMake> MotorMakes { get; set; }
        public DbSet<MotorModel> MotorModels { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
