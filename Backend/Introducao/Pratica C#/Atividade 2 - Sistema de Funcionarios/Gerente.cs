using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_2___Sistema_de_Funcionarios
{
    public class Gerente : Funcionario
    {
        public string NomeGerente;
        public double SalarioBaseGerente;
        public double SalarioTotal;
        public double Bonus;
        public Gerente(string NomeConstrutor, double SalarioBaseConstrutor) : base(NomeConstrutor, SalarioBaseConstrutor)
        {
            NomeGerente = NomeConstrutor;
            SalarioBaseGerente = SalarioBaseConstrutor;
            Bonus = 0.5;
        }

        public override double CalcularSalario()
        {
            SalarioTotal = SalarioBaseGerente * (Bonus + 1);
            return SalarioTotal;
        }

        public override void ExibirResumo()
        {
            Console.WriteLine($"Nome: {NomeGerente}\n Salario Total: {SalarioTotal:F2}\n Bonus salarial: {Bonus}");
        }
    }
}