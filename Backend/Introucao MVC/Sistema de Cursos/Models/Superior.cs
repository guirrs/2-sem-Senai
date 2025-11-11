using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Cursos.Models
{
    public class Superior : Curso
    {
        public Superior(){}
        public Superior(string NomeConstrutor, int AnoConstrutor) :base(NomeConstrutor, AnoConstrutor) {}

        public override double CalcularPreco()
        {
            return Horas * 40;
        }

    }
}