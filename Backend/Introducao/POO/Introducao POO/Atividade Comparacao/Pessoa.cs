using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Comparacao
{
    public class Pessoa
    {
        //para fazer que um valor possa ser nulo, ponha uma ? no final da declaracao e ponha nulo
        //! NOME NAO PODE SER NULO
        public string? Nome = null;

        public void Falar() => Console.WriteLine($"{Nome} esta falando!");
    }
}