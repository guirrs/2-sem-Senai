using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    public class Lampada : iDispositivo
    {
        public void Ligar() => Console.WriteLine("Lampada ligada!");
    }
}