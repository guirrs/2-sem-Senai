using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_3___Sistema_de_Personagens
{
    public class Guerreiro : Personagem
    {
        public string NomeGuerreiro { get; set; }

        private int 
         {get; set;}
        public int NivelGuerreiro
        {
            get { return NivelGuerreiroPersonagem; }
            set
            {
                if (value >= -1)
                {
                    NivelGuerreiroPersonagem = value;
                }

                else
                    Console.WriteLine("Nivel muito baixo!");
            }
        }

        public double Dano { get; set; }

        public Guerreiro(string NomeConstrutor, int NivelConstrutor) //: base(NomeConstrutor, NivelConstrutor)
        {
            NomeGuerreiro = NomeConstrutor;
            NivelGuerreiro = NivelConstrutor;
        }

        public override double CalcularPoder()
        {
            Dano = NivelGuerreiro * 8 + 20;
            return Dano;
        }

        public override void ExibirStatus()
        {
            Console.WriteLine($"Nome Personagem: {NomeGuerreiro}\nNivel: {NivelGuerreiro}\nClasse: Guerreiro");
        }
    }
}
