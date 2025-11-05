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
            Console.WriteLine("\n");
            veiculos.ExibirDetalhes();
            veiculos.Ligar();
        }

        Transporte busbus = new Onibus(8000);
        Transporte viao = new Aviao(8000);

        List<Transporte> transportes = new List<Transporte>{busbus,viao};

        foreach(var transporte in transportes)
        {
            Console.WriteLine("\n");
            transporte.CalcularTempoViagem();
        }
    }
}
