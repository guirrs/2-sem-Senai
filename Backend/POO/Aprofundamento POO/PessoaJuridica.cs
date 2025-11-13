using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprofundamento_POO
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ{get; set;} = string.Empty;
        public string RazaoSocial {get; set;} = string.Empty;

        public override void PagarImposto()
        {
            Console.WriteLine($"Pessoa Juridica: {RazaoSocial}, CNPJ: {CNPJ} pagando imposto");
        }
    }
}