using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_1___Sistema_de_Veiculos
{
    public class Moto : Veiculo
    {
        public string ModeloVeiculoMoto{get; set;}
        public double AnoVeiculoMoto{get; set;}
        public double custo; 
        public Moto(string Modelo, double Ano) : base(Modelo, Ano)
        {
            ModeloVeiculoMoto = Modelo;
            AnoVeiculoMoto = Ano;
            custo = 200;
        }
        public override void CalcularRevisao()
        {
            Console.WriteLine($"O custo é {custo}");
        }

        public override void ExibirResumo()
        {
            Console.WriteLine($"Modelo: {ModeloVeiculoMoto}");
            Console.WriteLine($"Ano: {AnoVeiculoMoto}");
            Console.WriteLine($"Custo: {custo}");
        }
    }
}