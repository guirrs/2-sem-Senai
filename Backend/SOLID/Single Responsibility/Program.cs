namespace Single_Responsibility;

class Program
{
    static void Main(string[] args)
    {
        Relatorio rel = new Relatorio();
        Enviar env = new Enviar();

        rel.Gerar();
        env.EnviarEmail();
    }
}
