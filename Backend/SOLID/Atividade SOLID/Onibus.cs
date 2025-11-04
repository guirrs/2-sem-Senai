using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_SOLID
{
    public class Onibus : Transporte
    {
        public Onibus(double DistanciaConstrutor) : base(DistanciaConstrutor);
        public double VelocidadeMedia = 60;

        public override double CalcularTempoViagem() 
        {
            TempoViagem = Distancia / VelocidadeMedia;
            return TempoViagem;
        }
    }
} 