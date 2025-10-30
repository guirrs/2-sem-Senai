using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel
{
    public class Quarto
    {
        public int Numero;
        public string Tipo;
        public double PrecoDiaria;
        public bool Disponivel;
        
        public Quarto(int numeroQuarto, string Tipo, double PrecoDiariaQuarto)
        {
            Numero = numeroQuarto;
            this.Tipo = Tipo;
            PrecoDiaria = PrecoDiariaQuarto;

            Disponivel = true;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Preco da Diaria: {PrecoDiaria:F2}");
        }

        public void Ocupar()
        {
            if(Disponivel)
            {
            Console.WriteLine($"Quarto ocupado");
            Disponivel = false;
            }
            else
            Console.WriteLine("O quarto ja esta ocupado");
        }

        public void Liberar()
        {
            Console.WriteLine($"Quarto desocupado");
            Disponivel = true;
        }
    }
}