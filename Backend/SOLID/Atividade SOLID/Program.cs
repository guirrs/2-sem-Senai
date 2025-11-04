namespace Atividade_SOLID;

class Program
{
    static void Main(string[] args)
    {
        Veiculo Cart = new Carro("Fusca","Nu",2004,2);
        Veiculo Motoca = new Moto("Hadashi","Volks", 2008,16);

        List<Veiculo> veiculo = new List<Veiculo>{Cart, Motoca};
        foreach (var veiculos in veiculo)
        {
            veiculos.ExibirDetalhes();
        }

        Transporte busbus = new Onibus(2);
    }
}
