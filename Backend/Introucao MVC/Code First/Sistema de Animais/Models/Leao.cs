using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Animais.Models
{
    public class Leao : Animal
    {
        public Leao () {}
        public Leao (string NomeConstrutor) : base(NomeConstrutor) 
        {
        }
        public override string EmitirSom()
        {
            return "Rugido";
        }
        public override string TipoAlimentacao()
        {
            return "Carnivoro";
        }
    }
}