using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    public class Interruptor
    {
        //* readonly eh uma varivel que so permite leitura
        private readonly iDispositivo dispositivo;

        public Interruptor(iDispositivo dispositivo)
        {
            //* This eh usado para nao confundir as variaveis
            this.dispositivo = dispositivo;
        }
    public void Acionar() => dispositivo.Ligar();

    }
}