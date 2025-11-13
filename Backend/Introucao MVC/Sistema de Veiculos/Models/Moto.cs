using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Veiculos.Models
{
    public class Moto : Veiculo
    {
        public double custo; 
        public Moto() {}
        public Moto(string ModeloConstrutor, double AnoConstrutor) : base(ModeloConstrutor, AnoConstrutor)
        {
            // custo = 200;
        }
        public override double CalcularRevisao()
        {
            return custo = 200;
        }
    }
}