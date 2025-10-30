using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_1___Sistema_de_Veiculos
{
    public abstract class Veiculo
    {
         public string ModeloVeiculo {get;set;}
         public double AnoVeiculo {get; set;}
        public Veiculo(string Modelo, double Ano)
        {
            ModeloVeiculo = Modelo;
            AnoVeiculo = Ano;
        }

        public abstract void CalcularRevisao();
        public virtual void ExibirResumo()
        {
            Console.WriteLine($"Modelo: {ModeloVeiculo}");
            Console.WriteLine($"Ano veiculo: {AnoVeiculo}");
        }
    }
}