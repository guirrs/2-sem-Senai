using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_3___Sistema_de_Personagens
{
    public class Mago : Personagem
    {
        public string NomeMago{get;set;}

        private int NivelMagoPersonagem {get; set;}
        //* Para usar o get de maneira correta, voce cria uma outra variavel vazia e nela que sera mandada a validacao do get 
        public int NivelMago{
            get {return NivelMagoPersonagem;}

            set
            {
            if(value >= -1)
            {
                NivelMagoPersonagem = value;
            }

            else
            Console.WriteLine("Nivel muito baixo!");
        }
        }
        public double Dano{get;set;}

        public Mago(string NomeConstrutor, int NivelConstrutor)// : base(NomeConstrutor, NivelConstrutor)
        {
            NomeMago = NomeConstrutor;
            NivelMago = NivelConstrutor;
        }

        public override double CalcularPoder()
        {
            Dano = NivelMago * 8 + 20;
            return Dano;
        }

        public override void ExibirStatus()
        {
            Console.WriteLine($"Nome Personagem: {NomeMago}\nNivel: {NivelMago}\nClasse: Mago");
        }
    }
}