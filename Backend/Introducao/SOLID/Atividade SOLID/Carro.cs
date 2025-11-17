using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_SOLID
{
    public class Carro : Veiculo , ICombustivel
    {
        public int Porta {get;set;}
        public double Litro{get;set;}
        public Carro(string MarcaConstrutor, string ModeloConstrutor, int AnoConstrutor, int PortaConstrutor) 
        : base(MarcaConstrutor, ModeloConstrutor, AnoConstrutor)
        {
            Porta = PortaConstrutor;
        }
        public override void Ligar() => Console.WriteLine($"O carro {Modelo} esta ligando");
        public override void ExibirDetalhes() => Console.WriteLine($"Marca: {Marca}\nModelo: {Modelo}\nAno: {Ano}\nPortas: {Porta}");

        public void VerificarCombustivel() => Console.WriteLine($"Litros: {Litro}");

        public double Abastecer(double LitrosInserido)
        {
            Litro += LitrosInserido;
            Console.WriteLine($"Veiculo abastecido, litros: {Litro}");
            return Litro;
        }

    }
}