using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_4___Sistema_de_Animais
{
    public abstract class Animal
    {
        public string Nome = "";

        public abstract void EmitirSom();
        public abstract void TipoAlimentacao();
    }
}