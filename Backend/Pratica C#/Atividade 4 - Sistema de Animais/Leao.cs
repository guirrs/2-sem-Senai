using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_4___Sistema_de_Animais
{
    public class Leao : Animal
    {
        public string NomeLeao {get;set;}

        public Leao (string NomeConstrutor)
        {
        NomeLeao = NomeConstrutor;
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Rugido");
        }
        public override void TipoAlimentacao()
        {
            Console.WriteLine("Tipo de Alimentacao: Carnivoro");
        }
    }
    }