using System;
class Program
{
        static void Main()
    {
        Vendedor vendedor = new Vendedor(); // Corrigido
        vendedor.nome = "Maria";
        vendedor.comissao = 1.1;
        Pessoa pessoa = new Pessoa(); // Corrigido
        pessoa.nome = "Joao";
        Console.WriteLine(pessoa.nome);
        Console.WriteLine(vendedor.nome);
        Console.WriteLine(vendedor.comissao);
    }
}