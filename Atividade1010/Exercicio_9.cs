using System;
namespace Atividade1010
{

class Exercicio_9
{
    static void Main()
    {
        
        int v,valorC;
		Console.WriteLine("Tamanho do vetor");
		v = int.Parse(Console.ReadLine());
		int[] numeros = new int[v];
		BibliotecaArray.geraVetor(numeros);
		BibliotecaArray.mostraVetor(numeros);

        Console.Write("\n\nInforme o valor a ser contado: ");
        valorC = int.Parse(Console.ReadLine());

        int contagem = 0;
        for (int i = quant - 1; i >= 0; i--)
        {
            if (int[i] == valorC)
            {
                contagem++;
            }
        }

        Console.WriteLine($"\nO valor {valorC} aparece {contagem} vezes no vetor.");
    }
}

}
