namespace Liskov_Substitution_Principle;

class Program
{
    static void Main(string[] args)
    {
        Ave a1 = new Andorinha();
        Ave a2 = new Pinguim();

        a1.Mover();
        a2.Mover();

        Console.WriteLine("");
        a1.Dormir();
        a2.Dormir();
    }
}
