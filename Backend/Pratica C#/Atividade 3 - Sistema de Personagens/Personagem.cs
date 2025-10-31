using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_3___Sistema_de_Personagens
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
 
        private int Nivel_Personagem {get; set;}
        public int Nivel
        {
            get { return Nivel_Personagem; }
            set
            {
                if (value >= -1)
                {
                    Nivel_Personagem = value;
                }

                else
                    Console.WriteLine("Nivel muito baixo!");
            }
        }
        // public Personagem(string NomeConstrutor, int NivelConstrutor)
        // {
        //     Nome = NomeConstrutor;
        //     Nivel = NivelConstrutor;
        // }
        public virtual void ExibirStatus()
        {
            Console.WriteLine($"Nome Personagem: {Nome}\nNivel: {Nivel}");
        }
        public abstract double CalcularPoder();
    }
}