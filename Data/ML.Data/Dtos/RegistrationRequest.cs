using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ML.Data.Dtos
{
    public class RegistrationRequest
    {
        
        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public int IdNumber { get; set; }
       
        public int PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
