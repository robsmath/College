using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha(100);
            String valor;
            for (int i = 0; i < 100; i++)
            {
                
                Console.Write("Digite um número ou uma operação: ");
                valor = Console.ReadLine();

                if (valor == "+")
                {
                    if(p.Vazia() == true)
                    {
                        Console.WriteLine("Pilha vazia, impossível efetuar o cálculo");
                    }
                    else
                    {
                        int x = p.Desempilhar();
                        int y = p.Desempilhar();
                        int resultado = y + x;
                        p.Empilhar(resultado);
                        Console.WriteLine(resultado);
                    } 
                    
                }
                else if(valor == "-")
                {
                    if (p.Vazia() == true)
                    {
                        Console.WriteLine("Pilha vazia, impossível efetuar o cálculo");
                    }
                    else
                    {
                        int x = p.Desempilhar();
                        int y = p.Desempilhar();
                        int resultado = y - x;
                        p.Empilhar(resultado);
                        Console.WriteLine(resultado);
                    }
                }
                else if(valor == "*")
                {
                    if (p.Vazia() == true)
                    {
                        Console.WriteLine("Pilha vazia, impossível efetuar o cálculo");
                    }
                    else
                    {
                        int x = p.Desempilhar();
                        int y = p.Desempilhar();
                        int resultado = y * x;
                        p.Empilhar(resultado);
                        Console.WriteLine(resultado);
                    }
                }
                else if(valor == "/")
                {
                    if (p.Vazia() == true)
                    {
                        Console.WriteLine("Pilha vazia, impossível efetuar o cálculo");
                    }
                    else
                    {
                        int x = p.Desempilhar();
                        int y = p.Desempilhar();
                        int resultado = y / x;
                        p.Empilhar(resultado);
                        Console.WriteLine(resultado);
                    }
                }
                else
                {
                    int numero = Convert.ToInt32(valor);
                    p.Empilhar(numero);
                }
                
                    

                


            }
        }
    }
}
