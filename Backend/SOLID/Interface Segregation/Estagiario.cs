using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    public class Estagiario : iTrabalhador
    {
        public void Trabalhar() => Console.WriteLine("Estagio esta a trabalhar...");
    }
}