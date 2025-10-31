using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_5___Sistema_de_Cursos
{
    public abstract class Curso
    {
        public int Horas {get;set;}
        public string Nome{get;set;}

        public abstract double calcularPreco();

        public void ExibirResumo()
        {
            Console.WriteLine($"Nome do Curso: {Nome}\nHoras: {Horas}");
        }
    }
}