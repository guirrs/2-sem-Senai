namespace Atividade_4___Sistema_de_Animais;

class Program
{
    static void Main(string[] args)
    {
        Animal Gato = new Leao("Florzinha");
        Animal Nanico = new Elefante("Pgneu");

        List<Animal> animais = new List<Animal>{Gato, Nanico};
        foreach(var animal in animais)
        {
            animal.EmitirSom();
            animal.TipoAlimentacao();
        }
    }
}
