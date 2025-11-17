using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_4___Sistema_de_Animais
{
    public class Elefante : Animal
    {
        public string NomeElefante {get;set;}

        public Elefante (string NomeConstrutor)
        {
        NomeElefante = NomeConstrutor;
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Barrito");
        }
        public override void TipoAlimentacao()
        {
            Console.WriteLine("Tipo de Alimentacao: Herbivoro");
        }
    }
}