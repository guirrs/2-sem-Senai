using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_SOLID
{
    public class Aviao : Transporte
    {
        public Aviao(double DistanciaConstrutor) : base(DistanciaConstrutor)
        {
        }
        public double VelocidadeMedia = 800;

        public override double CalcularTempoViagem() 
        {
            TempoViagem = Distancia / VelocidadeMedia;
            Console.WriteLine($"Tempo da viagem eh: {TempoViagem:F3}");
            return TempoViagem;
        }
    }
}