using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel
{
    public class ReservaVip : Reserva  
    {
        public float Desconto;
        //* :base eh usado para pegar os atributos da classe pai, eh usado :base(atributo1, atributo2)
        public ReservaVip(Hospede HospedeReserva, Quarto QuartoReserva, int DiasReservas, float Desconto) : base(HospedeReserva, QuartoReserva, DiasReservas)
        {
            this.HospedeReserva = HospedeReserva;
            this.QuartoReserva = QuartoReserva;
            Dias = DiasReservas;
            this.Desconto = Desconto;
        }


        public override double CalcularTotal()
        {
            preco = Dias * QuartoReserva.PrecoDiaria * (1 - Desconto);
            return preco;
        }

        public override void ResumoReserva()
        {
            Console.WriteLine($"Hospede: {HospedeReserva.Nome}");
            Console.WriteLine($"Quarto: {QuartoReserva.Numero}");
            Console.WriteLine($"Dias: {Dias}");
            Console.WriteLine($"Desconto aplicado: {Desconto*100}%");
            Console.WriteLine($"Preco: {preco:F2}");
        }
    }
}