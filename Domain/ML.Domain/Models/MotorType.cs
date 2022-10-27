using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Domain.Models
{
    public  class MotorType
    {
        public MotorType()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
