using System;
namespace Atividade1010
{

class Exercicio_8
{
    static void Main()
    {
        string letras;

        Console.WriteLine("Digite uma sequência de letras:");
        letras = Console.ReadLine();

        char[] vetorC = letras.ToCharArray();

        int quant = vetorC.Length;
        Console.WriteLine($"Quantidade de elementos: {quant}");
       
        Console.WriteLine("Vetor em ordem inversa:");
        for (int i = quant - 1; i >= 0; i--)
        {
            Console.Write(vetorC[i]);
        }

        Console.WriteLine(); 
    }
}
}
