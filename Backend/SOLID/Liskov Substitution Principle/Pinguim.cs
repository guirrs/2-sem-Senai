using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class Pinguim : Ave
    {
        public override void Mover() => Console.WriteLine("Andando...");

        public override void Dormir() => Console.WriteLine("Antartica precisa mim.");
    }
}