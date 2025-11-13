using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprofundamento_POO
{
    public abstract class Pessoa
    {
        public string nome{get;set;} = string.Empty;

        public List<Endereco> Enderecos {get;} = new List<Endereco>();

        public abstract void PagarImposto();

        public void AdicionarEndereco(Endereco endereco)
        {
            //* Add eh uma funcao do C# que adiciona conteudos a lista
            Enderecos.Add(endereco);
        }
    }
}