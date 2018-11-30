using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _222.EF
{
    public class User
{
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        [Column("Password")]
        public byte[] PasswordHash { get; set; }

        [Column("Salt")]
        public byte[] PasswordSalt { get; set; }
    }
}
