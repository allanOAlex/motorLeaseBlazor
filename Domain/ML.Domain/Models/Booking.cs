using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Domain.Models
{
    public  class Booking
    {
        public Booking()
        {

        }

        [Key]
        public int Id { get; set; }
        public int MotorModelId { get; set; }
        public int UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsComplete { get; set; }
        public string Comments { get; set; }

        [NotMapped]
        public MotorModel MotorModel { get; set; }

        [NotMapped]
        public User User { get; set; }
    }
}
