using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIRAMIDE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linha;
            
            int asterisco;
            Console.WriteLine("Digite o número de linhas: ");
            linha = Convert.ToInt32(Console.ReadLine());
            
            int espaco = linha - 1;
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < espaco; j++)
                {
                    Console.Write("*");
                    
                }
                 Console.WriteLine("");   
            }
        }
    }
}
