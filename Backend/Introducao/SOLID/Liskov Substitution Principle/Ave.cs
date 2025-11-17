using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public abstract class Ave
    {
        public abstract void Mover();

        public virtual void Dormir() => Console.WriteLine("Dormindo.");
    }
}