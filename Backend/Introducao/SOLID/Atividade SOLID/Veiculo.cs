using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_SOLID
{
    public class Veiculo
    {
        public string Marca {get;set;}
        public string Modelo {get;set;}
        public int Ano {get;set;}

        public Veiculo(string MarcaConstrutor, string ModeloConstrutor, int AnoConstrutor)
        {
            Marca = MarcaConstrutor;
            Modelo = ModeloConstrutor;
            Ano = AnoConstrutor;
        }
        
        public virtual void Ligar()=> Console.WriteLine($"O veiculo {Marca} esta ligando");

        public virtual void ExibirDetalhes() => Console.WriteLine($"Marca: {Marca}\nModelo: {Modelo}\nAno: {Ano}");
    }
}