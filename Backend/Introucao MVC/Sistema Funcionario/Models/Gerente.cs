using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Funcionario.Models
{
    public class Gerente : Funcionario
    {
        public Gerente(){}

        public Gerente(string NomeConstrutor, double SalarioBaseConstrutor) : base(NomeConstrutor, SalarioBaseConstrutor)
        {
        }

        public override double CalcularSalario()
        {
            SalarioBase *= 1.5;
            return SalarioBase;
        }
    }
}