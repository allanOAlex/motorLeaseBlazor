using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Data.Dtos
{
    public class RegistrationResponse
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int IdNumber { get; set; }

        public int PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
