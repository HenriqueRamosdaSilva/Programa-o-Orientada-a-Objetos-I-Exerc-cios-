using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();
        int op;

        do
        {
            Console.WriteLine("\n--- Menu da Fila de Atendimento ---");
            Console.WriteLine("1 - Adicionar cliente à fila");
            Console.WriteLine("2 - Atender próximo cliente");
            Console.WriteLine("3 - Ver número de clientes na fila");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("Escolha uma opção: ");
            string escolha = Console.ReadLine();
            if (int.TryParse(escolha, out op))
            {
                switch (op)
                {
                    case 1:
                        Console.Write("Digite o nome do cliente: ");
                        string nome = Console.ReadLine();
                        fila.Enqueue(nome);
                        Console.WriteLine($"{nome} foi adicionado à fila.");
                        break;

                    case 2:
                        if (fila.Count > 0)
                        {
                            string atendido = fila.Dequeue();
                            Console.WriteLine($"Atendendo: {atendido}");
                        }
                        else
                        {
                            Console.WriteLine("A fila está vazia.");
                        }
                        break;

                    case 3:
                        Console.WriteLine($"Clientes na fila: {fila.Count}");
                        break;

                    case 4:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um numero que seja uma das opçoes abaixo.");
            }

        } while (op != 4);
    }
}
