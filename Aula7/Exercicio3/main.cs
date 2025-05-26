/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        Console.WriteLine("Digite numeros interiros quantos quiser e quando quiser parar digite 0");
        HashSet<int> numerosUnicos = new HashSet<int>();
        int numero;
    
        do{
            Console.Write("Número: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numero)) {
                    if (numero != 0) {
                        numerosUnicos.Add(numero);
                    }
            }
                else {
                    Console.WriteLine("Entrada inválida. Tem que ser um número inteiro.");
                }
        }while (numero != 0);
         Console.WriteLine("\nNúmeros únicos digitados:");
        foreach (int todos in numerosUnicos)
        {
            Console.WriteLine(todos);
        }
    }
}