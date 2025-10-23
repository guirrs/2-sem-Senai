using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_POO
{
    public class Aluno : Pessoa
    {
        public string curso;

        //override: vai sobreescrever um codigo
        public override void Apresentar()
        {
            Console.WriteLine($"Sou o(a) aluno(a) {nome}, tenho {idade} anos e estudo {curso}.");
        }
    }
}