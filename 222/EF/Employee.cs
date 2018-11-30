using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _222.EF
{
    public class Employee
{
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Surname { get; set; }

        [MaxLength(300)]
        public string About { get; set; }

        [MaxLength(70)]
        public string ImageLocation { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
