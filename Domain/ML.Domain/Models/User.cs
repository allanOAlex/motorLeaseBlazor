using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Domain.Models
{
    public class User
    {
        public User()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is Required")]
        [Display(Name = "Username")]
        [RegularExpression(@"/^[a-zA-Z0-9]/", ErrorMessage = "Only Letters and Numbers Are Allowed For This Field.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [Display(Name = "Password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Password have minimum of * characters, must contain at least one uppercase English letter, one lowercase English letter, one digit and one special character.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Only Alpha Characters Are Allowed For This Field.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Only Alphabet Letters Are Allowed For This Field.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Id Number is Required")]
        [Display(Name = "ID Number")]
        [RegularExpression("^[0-9]", ErrorMessage = "Only Numbers Are Allowed For This Field.")]
        public int IdNumber { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [Display(Name = "Phone Number")]
        [MaxLength(10)]
        [MinLength(10)]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Only Letters and Numbers Are Allowed For This Field.")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [DefaultValue(false)]
        public bool IsAdmin { get; set; } = false;
    }
}
