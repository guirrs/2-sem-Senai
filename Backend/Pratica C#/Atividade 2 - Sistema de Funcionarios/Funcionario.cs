using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_2___Sistema_de_Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome {get;set;}
        public double SalarioBase{get;set;}

        public Funcionario(string NomeConstrutor, double SalarioBaseConstrutor)
        {
            Nome = NomeConstrutor;
            SalarioBase = SalarioBaseConstrutor;
        }

        public abstract double CalcularSalario();

        public virtual void ExibirResumo()
        {
            Console.WriteLine();
        }
    }
}