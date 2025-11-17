using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Animais.Models;

namespace Sistema_de_Animais.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Animal> TabelaAnimal{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Elefante>("Elefante")
            .HasValue<Leao>("Leao");
        }
    }
}