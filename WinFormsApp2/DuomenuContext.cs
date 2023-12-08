using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Permissions;

namespace WinFormsApp2
{
    public class DuomenuContext : DbContext
    {
        public DbSet<Grupe> Grupes { get; set; }
        public DbSet<Kursas> Kursai { get; set; }
        public DbSet<User> Naudotojai { get; set; }
        public DbSet<Pazymys> Pazymiai { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server = localhost; database = duomenys; user = root; password = test123");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kursas>()
                .HasMany(e => e.Grupes)
                .WithMany(e => e.Kursai)
                .UsingEntity("kursasgrupe");
            modelBuilder.Entity<Kursas>()
                .HasMany(e => e.Naudotojai)
                .WithMany(e => e.Kursai)
                .UsingEntity("kursasnaudotojai");
        }
    }
}
