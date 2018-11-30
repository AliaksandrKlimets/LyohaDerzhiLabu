using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _222.Models
{
    public class CreateVM
    {
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Range(0, 500000)]
        public int Price { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public IFormFile Image { get; set; }
    }
}
