namespace Hotel;

class Program
{
    static void Main(string[] args)
    {
        Hospede Joao = new Hospede("Joao", "423232", "1111111");
        Joao.ExibirInformacoes();
        Hospede Jaimir = new Hospede("Jaimir", "74748784", "222222222");

        Quarto QuartoSimples = new Quarto(12,"Simples", 70);
        Quarto QuartoSuite = new Quarto(33,"Suite", 100);

        Reserva Peble = new Reserva(Joao, QuartoSimples, 13);
        ReservaVip Burgues = new ReservaVip(Jaimir, QuartoSuite, 10, 0.1F);

        List<Reserva> reservas = new List<Reserva> {Peble, Burgues};

        foreach(var reserva in reservas)
        {
            Console.WriteLine($"\n");
            reserva.CalcularTotal();
            reserva.ResumoReserva();
        }
    }
}
