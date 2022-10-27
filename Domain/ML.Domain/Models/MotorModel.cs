using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Domain.Models
{
    public class MotorModel
    {
        public MotorModel()
        {

        }

        [Key]
        public int Id { get; set; }
        public int MotorTypeId { get; set; }
        public int MotorMakeId { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string MotorImage { get; set; }
        public string Registration { get; set; } 
        public decimal Price { get; set; } 
        public bool IsAvailable { get; set; }
        public bool IsActive{ get; set; }

        [NotMapped]
        public MotorType MotorType { get; set; }

        [NotMapped]
        public MotorMake MotorMake{ get; set; }
    }
}
