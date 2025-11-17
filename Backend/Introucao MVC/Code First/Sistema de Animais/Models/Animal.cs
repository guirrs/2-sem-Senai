using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Animais.Models
{
    public abstract class Animal
    {
        [Key]
        public int Id {get;set;}
        public string Nome {get;set;} = string.Empty;

        public Animal() {}

        public Animal (string NomeConstrutor)
        {
            Nome = NomeConstrutor;
        }

        public abstract string EmitirSom();
        public abstract string TipoAlimentacao();
    }
}
