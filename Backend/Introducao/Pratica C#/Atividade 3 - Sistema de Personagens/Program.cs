// See https://aka.ms/new-console-template for more information
namespace Atividade_3___Sistema_de_Personagens;
class Program
{
    static void Main(string[] args)
    {
        Personagem Lucas = new Mago("Leorio", 8);
        Personagem Maria = new Guerreiro("Leia", 10);

       List<Personagem> personagens = new List<Personagem> { Lucas, Maria };
   
    foreach (var personagem in personagens)
       {
          personagem.CalcularPoder();
          personagem.ExibirStatus();
      }
    }
}