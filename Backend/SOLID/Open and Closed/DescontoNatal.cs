
namespace Open_and_Closed
{
    public class DescontoNatal : Desconto
    {
        public override double Calcular(double valor)=> valor * 0.1;
    }
}