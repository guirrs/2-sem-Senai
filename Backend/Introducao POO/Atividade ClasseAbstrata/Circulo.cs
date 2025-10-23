using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_ClasseAbstrata
{
    public class Circulo : Forma
    {
        public double Raio;
        public override double CalcularArea() => Math.PI * Raio * Raio;
    }
}