namespace Atividade_ClasseAbstrata;

//* Na classe abstratada, a filhas nao precisar usar os metodos da pai, entratando, voce pode usar os metodos da classe pai
class Program
{
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo {Largura = 5, Altura = 3 };
        Circulo c = new Circulo{Raio = 3};

        r.MostrarTipo();
        Console.WriteLine($"Area do retangulo: {r.CalcularArea()}.");

        c.MostrarTipo();
        Console.WriteLine($"Area do circulo {c.CalcularArea()}");
    }
}
