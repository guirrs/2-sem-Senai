
namespace Aprofundamento_POO
{
    public class PessoaFisica : Pessoa
    {
        public string CPF {get; set;} = string.Empty;
        public DateTime DataNascimento {get;set;}

        public override void PagarImposto()
        {
            Console.WriteLine($"Pessoa fisica: {nome}, CPF: {CPF} pagando imposto");
        }
    }
}