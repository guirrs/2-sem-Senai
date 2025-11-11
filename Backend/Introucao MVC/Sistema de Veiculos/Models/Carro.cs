using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Veiculos.Models
{
    public class Carro : Veiculo
    {
        public double custo;

        public Carro() {}
        public Carro(string ModeloConstrutor, int AnoConstrutor) : base(ModeloConstrutor, AnoConstrutor)
        {

            custo = 500;
        }
        public override double CalcularRevisao()
        {
            return custo;
        }
    }
}