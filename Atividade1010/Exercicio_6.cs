using System;

/*Escreve um programa que sorteio, aleatoriamente, N números e armazene estes em um vetor. Em seguida, o
usuário digita um número e seu programa em C deve acusar se o número digitado está no vetor ou não. Se
estiver, diga a posição que está..*/

namespace Atividade1010
{
     class Exercicio_6
    {

        static int igual(int[] vetor,int numd)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == numd)
                {
                    return i;
                }

            }
            return numd;
        }

        static void Main()
        {
            int n;
            Console.WriteLine("Tamanho do vetor");
            n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];
            BibliotecaArray.geraVetor(numeros);
            BibliotecaArray.mostraVetor(numeros);

            Console.WriteLine("\nDigite um número");
            int num = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nO número: {num} está na tabela ná posisão {igual(numeros, num)}");

            Console.ReadKey();
        }
    }
}
