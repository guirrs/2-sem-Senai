using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_5___Sistema_de_Cursos
{
    public abstract class Curso
    {
        public string Nome{get;set;}
        public int Horas {get;set;}

        public Curso(string NomeConstrutor, int HorasConstrutor)
        {
            Nome = NomeConstrutor;
            Horas = HorasConstrutor;
        }

        public abstract double CalcularPreco();

        public virtual void ExibirResumo()
        {
            Console.WriteLine($"Nome do Curso: {Nome}\nHoras: {Horas}");
        }
    }
}