using System;

namespace Atividade1010
{
    internal class Exercicio_1_2_e_3
    {
        static double maiorValor(double[] vetor)
        {
            double maior = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                    maior = vetor[i];

            }
            return maior;
        }

        static double menorValor(double[] vetor)
        {
            double menor = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                    menor = vetor[i];

            }
            return menor;
        }

      /*  static void Main()
        {
            int n;
            Console.WriteLine("Tamanho do vetor");
            n = int.Parse(Console.ReadLine());
            double[] numeros = new double[n];
            BibliotecaArray.geraVetor(numeros);
            BibliotecaArray.mostraVetor(numeros);
            double res = maiorValor(numeros);
            Console.WriteLine($"\nMaior Valor: {res:F2}");
            Console.WriteLine($"Menor Valor: {menorValor(numeros):F2}");

            Console.ReadKey();
        }*/
    }
}
