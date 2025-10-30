using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel
{
    public class Reserva 
    {
        public Hospede HospedeReserva;
        public Quarto QuartoReserva;
        public int Dias;
        public double preco;
        public Reserva(Hospede HospedeReserva, Quarto QuartoReserva, int DiasReservas)
        {
            this.HospedeReserva = HospedeReserva;
            this.QuartoReserva = QuartoReserva;
            Dias = DiasReservas;
        }
        public virtual void ResumoReserva()
        {
            Console.WriteLine($"Hospede: {HospedeReserva.Nome}");
            Console.WriteLine($"Quarto: {QuartoReserva.Numero}");
            Console.WriteLine($"Dias: {Dias}");
            Console.WriteLine($"Preco: {preco}");
        }
        public virtual double CalcularTotal()
        {
            preco = Dias * QuartoReserva.PrecoDiaria;
            return preco;
        }
    }
}