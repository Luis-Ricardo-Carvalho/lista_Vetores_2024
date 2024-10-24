using System;

namespace Atividade1010
{
    class Exercicio_4
    {

        static int impares(int[] vetor)
        {
            int cont=0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i]%2 !=0)
                {
                    cont++;
                }
         
            }
            return cont;
        }

        /*static void Main()
        {
            int n;
            Console.WriteLine("Tamanho do vetor");
            n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];
            BibliotecaArray.geraVetor(numeros);
            BibliotecaArray.mostraVetor(numeros);


            Console.WriteLine($"\nO número de impares e: {impares(numeros)}");

            Console.ReadKey();
        }*/

    }
}
