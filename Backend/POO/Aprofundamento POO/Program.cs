namespace Aprofundamento_POO;

class Program
{
    static void Main(string[] args)
    {
        PessoaFisica pf = new PessoaFisica
        {
            nome = "Ana Paula",
            CPF = "111111",
            DataNascimento = new DateTime(2000, 4, 13)
        };

        pf.AdicionarEndereco(new Endereco
        {
            Rua = "Rua das Aguias",
            Numero = 13,
            Cidade = "Sao Jose",
            Estado = "SC",
            CEP = "0302",
            Comercial = false
        });

        PessoaJuridica pj = new PessoaJuridica
        {
            nome = "Loja exemplo",
            RazaoSocial = "Loja exemplo LTDA",
            CNPJ = "12313123"
        };

        pj.AdicionarEndereco(new Endereco
        {
            Rua = "Rua dos touros",
            Numero = 15,
            Cidade = "Flatuca",
            Estado = "RN",
            CEP = "23232032",
            Comercial = true
        });

        pf.PagarImposto();
        pj.PagarImposto();
    }
}