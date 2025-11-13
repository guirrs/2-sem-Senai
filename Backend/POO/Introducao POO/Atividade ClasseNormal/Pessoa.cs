using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_POO
{
    public class Pessoa
    {
        public string nome;
        public int idade;

// Virtual: vamos utilizar metodos de outra classe, podendo sobrescrever
        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola meu nome eh {nome} e tenho {idade} anos.");
        }
    }
}