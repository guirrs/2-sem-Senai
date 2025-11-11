using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Veiculos.Models;

namespace Sistema_de_Veiculos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Veiculo> TabelaVeiculos {get;set;} 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Moto>("Moto")
            .HasValue<Carro>("Carro");
        }
    }
}