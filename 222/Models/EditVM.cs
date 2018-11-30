using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _222.Models
{
    public class EditVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        [Range(0, 500000)]
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public IFormFile Image { get; set; }
    }
}