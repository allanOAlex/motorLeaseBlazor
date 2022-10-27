using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Domain.Models
{
    public class Review
    {
        public Review()
        {

        }

        [Key]
        public int Id { get; set; }
        public int BookingId { get; set; }
        public string Comments { get; set; }

        [NotMapped]
        public Booking Booking { get; set; }
    }
}
