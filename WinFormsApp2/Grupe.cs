
using System.ComponentModel.DataAnnotations;


namespace WinFormsApp2
{
    public class Grupe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Kursas> Kursai { get; } = new();
        public ICollection<User> Naudotojai { get; } = new List<User>();

    }
}
