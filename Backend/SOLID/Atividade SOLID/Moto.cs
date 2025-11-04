using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_SOLID
{
    public class Moto : Veiculo
    {
        public int Cilindrada {get;set;}

        //* Com o base nao a necessidade de criar os atributos da Pai
        public Moto(string MarcaConstrutor, string ModeloConstrutor, int AnoConstrutor, int CilindradaConstrutor) 
        : base(MarcaConstrutor, ModeloConstrutor, AnoConstrutor)
        {
            Cilindrada = CilindradaConstrutor;
        }
        public override void Ligar() => Console.WriteLine($"A moto {Modelo} de {Cilindrada}cc está pronta!");
        public override void ExibirDetalhes() => Console.WriteLine($"Marca: {Marca}\nModelo: {Modelo}\nAno: {Ano}\nCilindradas: {Cilindrada}");
    }
}