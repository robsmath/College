using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codCliente = 1;
            int saidaPedidos, saidaPagamento, saida;
            int opcaoMenu;
            
            //quando o cliente entra na loja: OPÇÃO 01
            Fila pedido = new Fila(100);

            //quando sair da fila de pedido: OPÇÃO 02
            Fila pagamento = new Fila(100);

            //quando sair da fila de pagamento: OPÇÃO 03
            Fila encomenda = new Fila(100);



            opcaoMenu = 0;
            while (opcaoMenu != 5)
            {
                Console.WriteLine("MENU: \n" +
                "1 - Inserção de cliente na fila de pedidos \n" +
                "2 - Remoção de cliente da fila de pedidos \n" +
                "3 - Remoção de cliente da fila de pagamentos \n" +
                "4 - Remoção de cliente da fila de encomendas \n" +
                "5 - Sair");
                opcaoMenu = Convert.ToInt32(Console.ReadLine());

                if (opcaoMenu == 1)
                {
                    pedido.Enfileirar(codCliente);
                    Console.WriteLine("Cliente " + codCliente + " entrou na fila de pedidos.");
                    codCliente++;
                }

                else if(opcaoMenu == 2)
                {
                    if(pedido.Vazia() == true)
                    {
                        Console.WriteLine("Fila de pedidos vazia, informe outra opção!!!");
                    }
                    else
                    {
                        saidaPedidos = pedido.Desenfileirar();
                        Console.WriteLine("Cliente " + saidaPedidos + " saiu da fila de pedidos.");
                        pagamento.Enfileirar(saidaPedidos);
                        Console.WriteLine("Cliente " + saidaPedidos + " entrou na fila de pagamentos.");
                    } 

                }
                else if(opcaoMenu == 3)
                {
                    if (pagamento.Vazia() == true)
                    {
                        Console.WriteLine("Fila de pagamentos vazia, informe outra opção!!!");
                    }
                    else
                    {
                        saidaPagamento = pagamento.Desenfileirar();
                        Console.WriteLine("Cliente " + saidaPagamento + " saiu da fila de pagamentos.");
                        encomenda.Enfileirar(saidaPagamento);
                        Console.WriteLine("Cliente " + saidaPagamento + " entrou na fila de encomendas.");
                    }
                        
                }
                else if(opcaoMenu == 4)
                {
                    if (encomenda.Vazia() == true)
                    {
                        Console.WriteLine("Fila de encomendas vazia, informe outra opção!!!");
                    }
                    else
                    {
                        saida = pagamento.Desenfileirar();
                        Console.WriteLine("Cliente " + saida + " saiu do restaurante.");
                    }
                        

                }
                

            }
            
            
            

            

            
        }
    }
}
