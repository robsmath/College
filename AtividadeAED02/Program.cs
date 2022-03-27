using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02AED
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            double[,] matriz = new double[6, 6];
            
            double somaDiagSec = 0;
            int quantElemDiagSec = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] = numAleatorio.Next(0, 10));
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    if (i + j <= matriz.GetLength(0) - 1)
                    {
                        quantElemDiagSec++;
                        somaDiagSec += matriz[i, j];
                    }
                }
            }

            double mediaDiagSec = somaDiagSec / quantElemDiagSec;

            Console.WriteLine("A soma dos valores até a diagonal secundária: " + somaDiagSec);

            Console.WriteLine("A média dos valores até a diagonal secundária: " + mediaDiagSec);
            
            Console.ReadLine();
        }
        
    }
}
