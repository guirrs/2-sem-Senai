using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_1___Sistema_de_Veiculos
{
    public class Carro : Veiculo
    {
        public string ModeloVeiculoCarro;
        public int AnoVeiculoCarro;
        public double custo; 
        public Carro(string Modelo, int Ano) : base(Modelo, Ano)
        {
            ModeloVeiculoCarro = Modelo;
            AnoVeiculoCarro = Ano;
            custo = 500;
        }
        public override void CalcularRevisao()
        {
            Console.WriteLine($"O custo é {custo}");
        }
        public override void ExibirResumo()
        {
            Console.WriteLine($"Modelo: {ModeloVeiculoCarro}");
            Console.WriteLine($"Ano: {AnoVeiculoCarro}");
            Console.WriteLine($"Custo: {custo}");
        }
    }
}