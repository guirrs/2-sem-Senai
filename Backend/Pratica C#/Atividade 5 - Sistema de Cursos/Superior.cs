using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_5___Sistema_de_Cursos
{
    public class Superior : Curso
    {
        public string NomeCursoSuperior{get;set;}
        public int HorasCursoSuperior{get;set;}
        public double ValorSuperior {get;set;}
        public Superior(string NomeConstrutor, int HorasConstrutor) : base(NomeConstrutor, HorasConstrutor)
        {
            NomeCursoSuperior = NomeConstrutor;
            HorasCursoSuperior = HorasConstrutor;
        }

        public override double CalcularPreco()
        {
            ValorSuperior = HorasCursoSuperior * 40;
            return ValorSuperior;
        }

        public override void ExibirResumo()
        {
            Console.WriteLine($"Nome do Curso: {NomeCursoSuperior}\nHoras: {HorasCursoSuperior}\nCurso: Superior\nValor: {ValorSuperior}");
        }
    }
}