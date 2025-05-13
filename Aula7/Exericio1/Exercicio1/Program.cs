using System;
using System.Collections.Generic;

public class Lista_De_Compras{
    static void Main (){
        int continuar = 1;
        List<string> Lista_de_Compras = new List<string>();

        while(continuar == 1){

            Console.WriteLine("\n Menu:");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Listar itens");
            Console.WriteLine("4. Mostrar quantidade total de itens");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch(opcao){

                case "1":
                    Console.Write("Digite o item para adicionar: ");
                    string itemadd = Console.ReadLine();
                    Lista_de_Compras.Add(itemadd);
                     Console.Write(itemadd + "Adicionado a lista de compras : ");
                break;
               case "2":
                    Console.Write("Digite o item para remover: ");
                    string itemremove = Console.ReadLine();
                    Lista_de_Compras.Remove(itemremove);
                     Console.Write(itemremove + "Removido da lista de compras : ");
                break;                
               case "3":
                    Console.Write("Todos os items da lista:\n ");
                    foreach (string itens in Lista_de_Compras)
                        {
                        Console.WriteLine($"- {itens}");
                        }
                    Console.Write("Lista finalizada");
                break;  
                case "4":
                    Console.WriteLine($"\nNúmero total de itens da lista: {Lista_de_Compras.Count}");
                break;
                case "5":
                continuar = 0;
                Console.WriteLine("Saindo do programa...");

                break;
            }
        }
    }
}

