namespace Atividade_Interface;

//* Quando se usa interface, todos os metodos da interface, as filhas devem  ter obrigatoriamente eles, senao o codigo da erro

class Program
{
    static void Main(string[] args)
    {
        Cachorro c = new Cachorro();
        Gato g = new Gato();

        c.EmitirSom();
        g.EmitirSom();
    }
}
