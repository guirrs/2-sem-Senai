namespace Atividade_POO;

class Program
{
    static void Main(string[] args)
    {
        
        //? Sem construtor
        /*
        Livro novoLivro = new Livro(); //* Sem parametros

        Console.WriteLine($"Titulo: {novoLivro.Titulo}");
        Console.WriteLine($"Ano: {novoLivro.AnoPublicacao}");
        Console.WriteLine($"Disponivel: {novoLivro.EstaDisponivel}");

        //* Pondo valores Manualmente
        novoLivro.Titulo = "Vida Secas";
        novoLivro.Autor = "Graciano Ramos";
        novoLivro.Preco = 65.49;
        novoLivro.AnoPublicacao = 1938;
        novoLivro.EstaDisponivel = true;

        Console.WriteLine("Exibindo detalhes");

        novoLivro.ExibirDetalhes();
        */

        //? Com construtor
        Console.WriteLine(">>> Sistema de controle de biblioteca <<<");
        Livro livro1 = new Livro("Arte da Guerra", "Sun Tzu", 1950, 95.85);
        Livro livro2 = new Livro("Dom Casmurro", "Machado de Assis", 1899, 76.98);

        Console.WriteLine($"\n");

        //* Interacao com os livros
        livro1.ExibirDetalhes();
        livro1.Emprestar();
        livro1.ExibirDetalhes();
        livro2.Emprestar();

        Console.WriteLine(">>> Interagindo com o Livro 2 <<<");
        livro2.ExibirDetalhes();
        livro2.Preco = 32.99;
        Console.WriteLine($"Atualizacao do preco {livro2.Titulo}");
        Console.WriteLine(livro2.Preco);
    }
}
