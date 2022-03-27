using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03AED
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int idade = 0;
            int sexo = 0;
            int estadoCivil = 0;
            int radioPref = 0;

            int somaIdades = 0;
            int mediaIdades = 0;

            ArrayList listaPessoas = new ArrayList();
           

            do
            {
                Console.WriteLine("Informe sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade != 0)
                {
                    listaPessoas.Add(idade);

                    Console.Clear();

                    Console.WriteLine("Qual o seu sexo? \n" +
                    "Digite 1 para MASCULINO \n" +
                    "2 para FEMININO \n" +
                    "3 para OUTROS: ");
                    sexo = Convert.ToInt32(Console.ReadLine());

                    while (sexo != 1 && sexo != 2)
                    {
                        Console.Clear();

                        Console.WriteLine("Valor digitado não é válido. \n" +
                        "Digite 1 para MASCULINO \n" +
                        "2 para FEMININO \n" +
                        "3 para OUTROS: ");
                        sexo = Convert.ToInt32(Console.ReadLine());
                    }

                    listaPessoas.Add(sexo);

                    Console.Clear();

                    Console.WriteLine("Qual o seu ESTADO CIVIL? \n" +
                        "Digite 1 para CASADO \n" +
                        "2 para SOLTEIRO \n" +
                        "3 para VIÚVO \n" +
                        "4 para DIVORCIADO \n" +
                        "5 para OUTROS: ");

                    estadoCivil = Convert.ToInt32(Console.ReadLine());

                    while (estadoCivil != 1 && estadoCivil != 2 && estadoCivil != 3 && estadoCivil != 4)
                    {
                        Console.Clear();

                        Console.WriteLine("Valor digitado não é válido. \n" +
                        "Digite 1 para CASADO \n" +
                        "2 para SOLTEIRO \n" +
                        "3 para VIÚVO \n" +
                        "4 para DIVORCIADO: \n" +
                        "5 para OUTROS: ");

                        estadoCivil = Convert.ToInt32(Console.ReadLine());
                    }

                    listaPessoas.Add(estadoCivil);

                    Console.Clear();

                    Console.WriteLine("Qual a sua estação de RÁDIO preferida? \n" +
                        "Digite 1 para BHFM" +
                        "2 para 98FM \n" +
                        "3 para JOVEM PAN \n" +
                        "4 para ITATIAIA \n" +
                        "5 para CDL \n" +
                        "6 para OUTROS: ");

                    radioPref = Convert.ToInt32(Console.ReadLine());

                    while (radioPref != 1 && radioPref != 2 && radioPref != 3 && radioPref != 4 && radioPref != 5)
                    {
                        Console.Clear();

                        Console.WriteLine("Valor digitado não é válido. \n" +
                        "Digite 1 para BHFM" +
                        "2 para 98FM \n" +
                        "3 para JOVEM PAN \n" +
                        "4 para ITATIAIA \n" +
                        "5 para CDL \n" +
                        "6 para OUTROS: ");

                        radioPref = Convert.ToInt32(Console.ReadLine());
                    }

                    listaPessoas.Add(radioPref);




                } 
            } while (idade != 0);
            
            foreach (int estacoes in listaPessoas)
            {
                Console.WriteLine("{0}", estacoes);
            }


            /*
            foreach (int idades in listaIdade)
            {
                Console.WriteLine("Idades armazenadas: " + idades);
            }
            
            foreach (int sex in listaSexo)
            {
                Console.WriteLine("Sexos armazenados: " + sex);
            }

            foreach (int civil in listaEstadoCivil)
            {
                Console.WriteLine("Estados Civis armazenados: " + civil);
            }

             * foreach (int idades in listaIdade)
            {
                Convert.ToInt32(somaIdades += idades);
            }

            Console.WriteLine(somaIdades);

            */





        }


    }
}
