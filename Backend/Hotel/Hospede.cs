using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel
{
    public class Hospede
    {
         public string Nome{get;set;}
        public string CPF{get;set;}
        public string Telefone{get;set;}

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Telefone {Telefone}");
        }
    }
}