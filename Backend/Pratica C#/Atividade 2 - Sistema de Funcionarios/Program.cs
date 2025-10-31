namespace Atividade_2___Sistema_de_Funcionarios;

class Program
{
    static void Main(string[] args)
    {
        Funcionario Flavio = new Gerente("Flavio", 10000.93);
        Funcionario Gerso = new Vendedor("Gerso", 5000);

        List<Funcionario> funcionarios = new List<Funcionario> {Flavio, Gerso};

        foreach(var funcionario in funcionarios) 
        {
            Console.WriteLine("\n");
            funcionario.CalcularSalario();
            funcionario.ExibirResumo();
        }
    }
}
