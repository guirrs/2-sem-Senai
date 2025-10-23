using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class Andorinha : Ave
    {
        public override void Mover() => Console.WriteLine("VOANDOOOOOO...");
    }
}