using System;
using System.Collections.Generic;

public class Catalogo_De_Produtos {
    static void Main (){
        int continuar = 1;
        Dictionary<int, string> Catalogo_de_Produtos = new Dictionary<int, string>();

        while(continuar == 1){

            Console.WriteLine("\n Menu:");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Buscar Produto pelo código");
            Console.WriteLine("3. Listar Podutos");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch(opcao){

                case "1":
                    Console.Write("Digite o codigo do produto para adicionar: ");
                    int idadd =int.Parse( Console.ReadLine());
                    if (Catalogo_de_Produtos.ContainsKey(idadd))
                    {
                        Console.WriteLine("Erro: Já existe um produto com este código.");
                    }
                        else
                        {
                            Console.Write("Digite o nome do produto para adicionar: ");
                            string nomeadd = Console.ReadLine();
                            Catalogo_de_Produtos.Add(idadd, nomeadd);
                        }
                    
                    break;
               case "2":
                    Console.WriteLine($"Código do produto: {Catalogo_de_Produtos.Count}");
                    int idaddb =int.Parse( Console.ReadLine());
                    Console.WriteLine($"Produto com ID : {Catalogo_de_Produtos[idaddb]}"); //
                break;                
               case "3":
                    Console.WriteLine("\nProdutos do catalogo:");
                    foreach (KeyValuePair<int, string> par in Catalogo_de_Produtos)
                    {
                    Console.WriteLine($"- ID: {par.Key}, Nome: {par.Value}");
                    }
                break;  
                case "4":
                    Console.WriteLine($"\nNúmero total de itens da lista: {Catalogo_de_Produtos.Count}");
                break;
            }
        }
    }
}

