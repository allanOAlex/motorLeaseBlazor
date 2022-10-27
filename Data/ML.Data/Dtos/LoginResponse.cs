using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Data.Dtos
{
    public class LoginResponse
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public bool IsAdmin { get; set; }
    }
}
