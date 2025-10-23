namespace Atividade_POO;
//* Classe comuns precisam de Virtual para dar override
class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa
        {
            nome = "Kessia",
            idade = 25
        };

        Aluno a = new Aluno
        {
            nome = "Paulo",
            idade = 20,
            curso = "Programa"
        };

        p.Apresentar();
        a.Apresentar();
    }
}
