using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAED
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantElementos = 0;
            int soma = 0;
            int media = 0;
            int indiceMaior = 0;
            int indiceMenor = 0;
            int quantElemAbaixoMedia = 0;

            int maior = 0, menor = 0;

            Console.WriteLine("Informe a quantidade de elementos: ");
            quantElementos = Convert.ToInt32(Console.ReadLine());

            int [] vetor = new int [quantElementos];

            //preenchendo o vetor com valores

            for (int i = 0; i<quantElementos; i++)
            {
                Console.WriteLine("Informe o " + (i+1) + "º número: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            //soma dos valores no vetor
            for (int i = 0; i<quantElementos; i++)
            {
                soma += vetor[i];
            }

            //media dos valores no vetor
            media = (soma / vetor.Length);

            //verificando os valores que estão abaixo da média no vetor
            foreach (int valores in vetor)
            {
                if (valores < media)
                {
                    quantElemAbaixoMedia++;
                }
            }

            //encontra o maior e o menor número no vetor e sua posição (indice)
            for (int i = 0; i < quantElementos; i++)
            {
                if (i == 0)
                {
                    menor = vetor[0];
                    maior = vetor[0];
                }

                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    indiceMenor = i;
                }
                else if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    indiceMaior = i;
                }
            }

            Console.WriteLine("Quantidade de elementos: " + quantElementos);

            Console.WriteLine("Soma de todos os elementos: " + soma);

            Console.WriteLine("Média de todos os elementos: " + media);

            Console.WriteLine("Quantidade de elementos abaixo da média: " + quantElemAbaixoMedia);

            Console.WriteLine("Índice do maior elemento: " + indiceMaior);

            Console.WriteLine("Índice do menor elemento: " + indiceMenor);






        }
    }
}
