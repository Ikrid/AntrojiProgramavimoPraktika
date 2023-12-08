using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Kursas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Pazymys> Pazymiai { get; } = new List<Pazymys>();
        public List<Grupe> Grupes { get; } = new();
        public List<User> Naudotojai { get; } = new();

    }
}
