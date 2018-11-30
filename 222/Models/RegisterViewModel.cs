using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _222.Models
{
    public class RegisterViewModel
{
        [Required(ErrorMessage = "Enter email")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Enter correct email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter surname")]
        public string Surname { get; set; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [MinLength(7, ErrorMessage = "Password should me more than 6 symbols")]
        public string PasswordString { get; set; }
    }
}
