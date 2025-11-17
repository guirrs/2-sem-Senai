namespace Atividade_5___Sistema_de_Cursos;

class Program
{
    static void Main(string[] args)
    {
        Curso curso1 = new Tecnico("Desenvolvimento de Sistema", 1600);
        Curso curso2 = new Superior("Cyberseguranca", 2000);

        List<Curso> cursos = new List<Curso>{curso1, curso2};

        foreach(var curso in cursos)
        {
            Console.WriteLine("\n");
            curso.CalcularPreco();
            curso.ExibirResumo();
        }
    }
}
