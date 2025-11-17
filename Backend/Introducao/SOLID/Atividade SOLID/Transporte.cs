using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_SOLID
{
    public abstract class Transporte
    {
        public double TempoViagem = 0;
        public double DistanciaInserida { get; set; }
        public double Distancia
        {
            get
            {
                return DistanciaInserida;
            }
            set
            {
                if (value > 0)
                    DistanciaInserida = value;
                else
                Console.WriteLine("Nao eh permitido ditancia negativa.");
            }
        }
        public Transporte(double DistanciaConstrutor)
        {
            Distancia = DistanciaConstrutor;
        }
        public abstract double CalcularTempoViagem();
        public void IniciarViagem() => Console.WriteLine("Viagem Iniciada...");
    }
}