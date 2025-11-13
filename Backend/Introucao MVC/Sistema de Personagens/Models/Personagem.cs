using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Personagens.Models
{
    public abstract class Personagem
    {
        [Key]
        public int Id {get; set;}
        public string Nome { get; set; } = string.Empty;

        private int Nivel_Personagem { get; set; }
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
        public Personagem() {}
        public Personagem(string NomeConstrutor, int NivelConstrutor)
        {
            Nome = NomeConstrutor;
            Nivel = NivelConstrutor;
        }
        public abstract double CalcularPoder();
    }
}