using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_5___Sistema_de_Cursos
{
    public class Tecnico : Curso
    {
        public string NomeCursoTecnico{get;set;}
        public int HorasCursoTecnico{get;set;}
        public double ValorTecnico {get;set;}
        public Tecnico(string NomeConstrutor, int HorasConstrutor) : base(NomeConstrutor, HorasConstrutor)
        {
            NomeCursoTecnico = NomeConstrutor;
            HorasCursoTecnico = HorasConstrutor;
        }

        public override double CalcularPreco()
        {
            ValorTecnico = HorasCursoTecnico * 40;
            return ValorTecnico;
        }

        public override void ExibirResumo()
        {
            Console.WriteLine($"Nome do Curso: {NomeCursoTecnico}\nHoras: {HorasCursoTecnico}\nCurso: Tecnico\nValor: {ValorTecnico}");
        }
    }
}
