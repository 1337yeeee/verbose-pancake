using System;
using System.ComponentModel.DataAnnotations;

namespace Vision.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Sexgender { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }



    }
}
