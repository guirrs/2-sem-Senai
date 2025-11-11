using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Cursos.Models
{
    public abstract class Curso
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;
        public int Horas { get; set; }

        public Curso() { }
        public Curso(string NomeConstrutor, int HorasConstrutor)
        {
            Nome = NomeConstrutor;
            Horas = HorasConstrutor;
        }

        public abstract double CalcularPreco();
    }
}