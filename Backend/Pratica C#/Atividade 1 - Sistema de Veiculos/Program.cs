namespace Atividade_1___Sistema_de_Veiculos;

class Program
{
    static void Main(string[] args)
    {
        Veiculo Cart = new Carro("Hotwhells", 2023 );
        Veiculo Motoca = new Moto("Moto plays", 2012);

        Cart.ExibirResumo();
        Motoca.ExibirResumo();
    }
}
