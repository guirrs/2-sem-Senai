using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Interface
{
    public class Cachorro : iAnimal
    {
        public void EmitirSom() => Console.WriteLine("Au Au!");
    }
}