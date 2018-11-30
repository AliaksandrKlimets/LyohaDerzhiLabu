using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _222.Models
{
    public class LoginViewModel
{
    [Required(ErrorMessage = "Required field")]
    [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Enter correct email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Required field")]
    public string PasswordString { get; set; }
}
}
