using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _222.Models
{
    public class EditModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string About { get; set; }
        public DateTime? BitrhDate { get; set; }
        public IFormFile Image { get; set; }
    }
}
