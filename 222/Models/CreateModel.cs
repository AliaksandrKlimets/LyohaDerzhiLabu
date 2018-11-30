using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _222.Models
{
    public class CreateModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Surname { get; set; }
        [Required]
        public string About { get; set; }
        public DateTime? BirthDate { get; set; }
        public IFormFile Image { get; set; }
    }
}
