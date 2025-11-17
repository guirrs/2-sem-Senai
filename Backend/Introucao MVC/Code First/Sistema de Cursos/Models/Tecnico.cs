using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Cursos.Models
{
    public class Tecnico : Curso
    {
        //* Metodo de sobrecarga
        public Tecnico() { }
        public Tecnico(string NomeConstrutor, int HorasConstrutor) : base(NomeConstrutor, HorasConstrutor) { }

        public override double CalcularPreco()
        {
            return Horas * 20;
        }
    }
}