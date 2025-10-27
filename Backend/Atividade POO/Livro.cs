using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_POO
{
    public class Livro
    {
        public string Titulo {get; set;}
        public string Autor {get;set;}
        //* get permite voce fazer a leitura do ano
        public int AnoPublicacao {get;set;}
        /*
        {
        get
        {
            return AnoPublicacao;
        }
        //* set eh usado para validar o valor dentro da classe
        set
        {
            if(value > 0)
            {
                AnoPublicacao = value;
            }

            else
            {
                Console.WriteLine("Ano de publicacao é invalido");
            }
        }
        }
        */
        public double Preco{get;set;}
        //*Fazer a variavel receber depois de escrita, faz com que ela tenha um padrao caso nao ponham nada
        public bool EstaDisponivel{get;set;} = true;

        //* CONSTRUTOR
        //* É um metodo especial usado para inicializar o estado do objeto

        public Livro(string tituloConstrutor, string autorConstrutor, int anoConstrutor, double precoConstrutor)
        {
            Titulo = tituloConstrutor;
            Autor = autorConstrutor;
            AnoPublicacao = anoConstrutor;
            Preco = precoConstrutor;

            //* Defininfo o valor inicial como true
            EstaDisponivel = true;

            Console.WriteLine("Livro foi criado e esta disponivel");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("*** Detalhes do Livro ***");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Publicacao: {AnoPublicacao}");
            //* :F2 faz com que o a variavel fique apenas em 2 casas decimais
            Console.WriteLine($"Preco: {Preco:F2}");

            if(EstaDisponivel)
            {
                Console.WriteLine("Status: esta disponivel para emprestimo");
            }

            else
            {
                Console.WriteLine("Status: Emprestado!(Indisponivel)");
            }
        }

        public void Emprestar()
        {
            if(EstaDisponivel)
            {
            EstaDisponivel = false;
            Console.WriteLine($"O livro: {Titulo} foi emprestado");
            }
            
            else
            {
                Console.WriteLine($"O livro {Titulo} ja foi emprestado");
            }
        }
    }
}