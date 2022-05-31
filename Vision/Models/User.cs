using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vision.Models
{
    public class User
    {
        [NotMapped]
        public static User _default { get; set; }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Sexgender { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }


    }
}
