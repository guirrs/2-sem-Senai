using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema_Funcionario.Models;

namespace Sistema_Funcionario.Data
{
    public class AppDbContext : DbContext
    {
        //* Recebe as opcoes de configurancao do banco
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        //* Direciona a classe (Funcionario) para a tabela(TabelaFuncionario)
        //? Quando voce usar uma outra classe, use CRTL + SPACE, pois ele vai programa vai puxar ela do programa usando o using
        //? nesse caso using Sistema_Funcionario.Models;
        public DbSet<Funcionario> TabelaFuncionario {get; set;}

        //* Vai sobre escrever o mapeamento do modelo(uma unica tabela para funcionario)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>() //* Comeca a configutara a entidade base funcionario
            .HasDiscriminator<string>("Cargo") //* Cria uma unica tabela, diferenciando Gerente e vendendor pelo cargo
            .HasValue<Gerente>("Gerente")//*Quando a intancia foi gerente, grava gerente como cargo
            .HasValue<Vendedor>("Vendedor");//*Quando a instancia for vendedor, grava vendedor como cargo
        }
    }
}