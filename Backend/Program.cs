// 
using System.Runtime.ConstrainedExecution;

namespace Backend;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Bem vindo(a) ao sistema.");

        //* Entrada de dados
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        //int.Parse() Converte a String para numeros
        int idade = int.Parse(Console.ReadLine());

        // $ permite usar caracteres especias como \n \r e tambem por variaveis no conteudo
        Console.WriteLine($"\nOla, {nome}! Voce tem {idade} anos.");

        if(idade<18)
        Console.WriteLine("Voce eh de maior");

        else
        Console.WriteLine("VOCE EH MENOOOOO");

        //* Menu
        Console.WriteLine("\nEscolhe uma opcao:");
        Console.WriteLine("1- Ver a tabuada de um numero: ");
        Console.WriteLine("2- Contar ate um numero");
        Console.WriteLine("3- Sair");
        Console.WriteLine("Digite a sua opcao");

        int opcao = int.Parse(Console.ReadLine());

        swirch(opcao)
            case 1:

            Console.WriteLine($"\nInsira um valor:");
            int valorTabuada = int.Parse(Console.ReadLine());

            int tabuada = 0;

            for(int i = 1; i <= 11; i++)
            {
                tabuada = valorTabuada;
                tabuada *= i;
                Console.WriteLine(tabuada);
        
            break;

            case 2 :
        
            Console.WriteLine($"\nInsira um valor:");
            int numeroContador = int.Parse(Console.ReadLine());

            for(int i = 0; i <= numeroContador; i++)
            {
                Console.WriteLine(i);
            }
        

       case 3:
        Console.WriteLine($"Fim do Sistema");
        break;

        default;

        Console.WriteLine("Insira um valor validao");
        opcao = int.Parse(Console.ReadLine());
        
        break;
        */
    //* Fibonnaci
    Console.WriteLine($"\nInsira um valor para o valor de Fibonnaci:");
    int numeroFibonnaci = int.Parse(Console.ReadLine());

    int resultado = 1;
    int resultadoAnterior = 0;
    int intermediador;

    for(int i = 0; i < numeroFibonnaci -1; i++)
    {
        resultado += resultadoAnterior;
        intermediador = resultadoAnterior;

        Console.WriteLine(resultado);

        resultadoAnterior = resultado;
        resultadoAnterior -= intermediador;
    }
}
}