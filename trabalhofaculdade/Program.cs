using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> filaPedidos = new Queue<string>();
        Stack<string> pilhaPedidosProntos = new Stack<string>();
        List<string> pedidosEntregues = new List<string>();

        while (true)
        {
            Console.WriteLine("Bem-vindo ao Restaurante! O que deseja fazer?");
            Console.WriteLine("1. Fazer um pedido");
            Console.WriteLine("2. Preparar próximo pedido");
            Console.WriteLine("3. Entregar pedido");
            Console.WriteLine("4. Visualizar pedidos entregues");
            Console.WriteLine("5. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite o nome do pedido:");
                    string pedido = Console.ReadLine();
                    filaPedidos.Enqueue(pedido);
                    Console.WriteLine($"Pedido \"{pedido}\" adicionado à fila.");
                    break;

                case "2":
                    if (filaPedidos.Count > 0)
                    {
                        string proximoPedido = filaPedidos.Dequeue();
                        pilhaPedidosProntos.Push(proximoPedido);
                        Console.WriteLine($"Pedido \"{proximoPedido}\" preparado.");
                    }
                    else
                    {
                        Console.WriteLine("Não há pedidos pendentes.");
                    }
                    break;
                   
                        Console.Clear();
                case "3":
                    if (pilhaPedidosProntos.Count > 0)
                    {
                        string pedidoEntregue = pilhaPedidosProntos.Pop();
                        pedidosEntregues.Add(pedidoEntregue);
                        Console.WriteLine($"Pedido \"{pedidoEntregue}\" entregue.");
                    }
                    else
                    {
                        Console.WriteLine("Não há pedidos preparados para entrega.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Pedidos entregues:");
                    foreach (var pedidoEntregue in pedidosEntregues)
                    {
                        Console.WriteLine(pedidoEntregue);
                    }
                    break;

                case "5":
                    Console.WriteLine("Saindo do programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }
}
