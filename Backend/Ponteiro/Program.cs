namespace Ponteiro;

class Program
{
    static unsafe void Main(string[] args)
    {
        int variavelA = 10;
        Console.WriteLine($"variavel: {variavelA}");

        //* Quando usa * voce indica ao computador que o valor eh um ponteiro
        int* ponteiro = &variavelA;
        Console.WriteLine($"Endereco da memoria {(ulong)ponteiro}");

        //*Manipulando a variavel pela memoria
        *ponteiro = 75;
        Console.WriteLine($"Endereco da memoria {(ulong)variavelA}\n");

        int[] numeros = {10,20,30,40};

        //* Voce fixou os numeros dentro do bloco
        fixed(int* pArray = numeros)
        {
            Console.WriteLine($"Endereco do array {(ulong)pArray}");
            Console.WriteLine($"pArray[0] {*(pArray)}");
            Console.WriteLine($"pArray[1] {*(pArray + 1)}");
            Console.WriteLine($"pArray[2] {*(pArray + 2)}");
            Console.WriteLine($"pArray[3] {*(pArray + 3)}");
            //* Como voce passou da memoria inserida, o computador iria acessar um endereco acima do seu inserido, podendo pegar i,a variavel do seu computador e ate outro programa, mas o Windowns bloquioa e retorna zero
            Console.WriteLine($"pArray[?] {*(pArray + 4)}");
        }
    }
}
