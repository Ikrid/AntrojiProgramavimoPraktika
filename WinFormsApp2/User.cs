using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp2
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public ICollection<Pazymys> Pazymiai { get; } = new List<Pazymys>();
        public int? GrupeId { get; set; }
        public Grupe? Grupe { get; set; }
        public List<Kursas> Kursai { get; } = new();
     


    }
}
