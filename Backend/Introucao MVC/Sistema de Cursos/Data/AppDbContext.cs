using Microsoft.EntityFrameworkCore;
using Sistema_de_Cursos.Models;

namespace Sistema_de_Cursos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Curso> TabelaCurso{get;set;}

        //? OnModelCreating eh um modelo de criacao, na qual pode ser sobreescrito
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Tecnico>("Tecnico")
            .HasValue<Superior>("Superior");
        }
    }
}