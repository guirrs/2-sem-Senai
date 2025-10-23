using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_ClasseAbstrata
{
    public abstract class Forma
    {
        //* Declarar esse metodo como abstrado, esta obrigando a herenca a usa-lo e sobreescreve-lo(override)
        public abstract double CalcularArea();

        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geometrica.");
        }
    }
}