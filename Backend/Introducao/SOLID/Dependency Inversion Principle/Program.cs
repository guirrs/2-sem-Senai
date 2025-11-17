namespace Dependency_Inversion_Principle;

class Program
{
    static void Main(string[] args)
    {
        iDispositivo lampada = new Lampada();
        Interruptor interruptorLampada = new Interruptor(lampada);

        iDispositivo ar = new ArCondicionado();
        Interruptor interruptorAr = new Interruptor(ar);

        interruptorAr.Acionar();
        interruptorLampada.Acionar();
    }
}
