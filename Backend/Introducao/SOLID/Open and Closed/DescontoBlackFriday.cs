using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Open_and_Closed
{
    public class DescontoBlackFriday : Desconto
    {
        public override double Calcular(double valor) => valor * 0.2;
    }
}