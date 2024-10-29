using System;
namespace Atividade1010
{
class Exercicio_7
{

	static int multiplica(int[] vetor, int[] vetorw)
	{
		int[] soma;
		for (int i = 0; i < vetor.Length; i++)
		{
			soma[i] = vetor[i]*vetor2[i];


		}
		return soma;
	}

	static void Main()
	{
		int v, v2;
		Console.WriteLine("Tamanho do vetor");
		v = int.Parse(Console.ReadLine());
		int[] numeros = new int[v];
		BibliotecaArray.geraVetor(numeros);
		BibliotecaArray.mostraVetor(numeros);

		Console.WriteLine("Tamanho do vetor de outro vetor");
		v2 = int.Parse(Console.ReadLine());
		int[] numeros2 = new int[v2];
		BibliotecaArray.geraVetor(numeros2);
		BibliotecaArray.mostraVetor(numeros2);


		Console.WriteLine($"\nA multiplicaC'C#o dos nC:meros e: {BibliotecaArray.mostraVetor(multiplica(numeros,numeros2))}");

		Console.ReadKey();
	}

}
}
