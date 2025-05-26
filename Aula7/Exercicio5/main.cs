using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string palavraInvertida = "";
        Stack<char> pilha = new Stack<char>();
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        foreach (char c in palavra)
        {
            pilha.Push(c);
        }
        while (pilha.Count > 0)
        {
            palavraInvertida += pilha.Pop();
        }
        Console.WriteLine("Palavra invertida: " + palavraInvertida);
    }
}
