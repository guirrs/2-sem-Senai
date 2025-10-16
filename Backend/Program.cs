// 
namespace Backend;

class Program
{
    static void Main(string[] args)
    {
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
        Console.WriteLine("4- Escolha sua opcao");

        int opcao = int.Parse(Console.ReadLine());
    }
}
