using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_2___Sistema_de_Funcionarios
{
    public class Vendedor : Funcionario
    {
        public string NomeVendedor;
        public double SalarioBaseVendedor;
        public double SalarioTotal;
        public double Bonus;
        public Vendedor(string NomeConstrutor, double SalarioBaseConstrutor) : base(NomeConstrutor, SalarioBaseConstrutor)
        {
            NomeVendedor = NomeConstrutor;
            SalarioBaseVendedor = SalarioBaseConstrutor;
            Bonus = 0.2;
        }

        public override double CalcularSalario()
        {
            SalarioTotal = SalarioBaseVendedor * (Bonus + 1);
            return SalarioTotal;
        }

        public override void ExibirResumo()
        {
            Console.WriteLine($"Nome: {NomeVendedor}\n Salario Total: {SalarioTotal:F2}\n Bonus salarial: {Bonus}");
        }
    }
}