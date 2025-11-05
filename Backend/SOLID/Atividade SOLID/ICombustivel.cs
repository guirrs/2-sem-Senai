using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_SOLID
{
    public interface ICombustivel
    {
        public double Litro{get;set;}
        public double Abastecer(double LitrosInserido);
        public void VerificarCombustivel();
    }
}