using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Pazymys
    {
        [Key]
        public int Id { get; set; }
        public int Value { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int KursasId { get; set; }
        public Kursas Kursas { get; set; } = null!;

    }
}
