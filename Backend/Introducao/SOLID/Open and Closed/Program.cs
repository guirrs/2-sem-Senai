namespace Open_and_Closed;

class Program
{
    static void Main(string[] args)
    {
        Desconto d1 = new DescontoNatal();
        Desconto d2 = new DescontoBlackFriday();

        // :C poe o formato monetario do sistema
        Console.WriteLine($"Natal: {d1.Calcular(1000):C}");
        Console.WriteLine($"Black Friday: {d2.Calcular(1000):C}");

        Console.WriteLine($"\nBlack Friday: {d2.Calcular(2000)}");
    }
}
