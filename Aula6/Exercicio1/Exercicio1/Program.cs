using System;

    class Program{
        static void Main(){
            Console.WriteLine("Digite o nome do produto");
            string nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome))
            {
            throw new  ArgumentException("O nome não pode ser nulo.");
            }

            Console.WriteLine("Digite o preço do produto");
            double preco =double.Parse (Console.ReadLine());
            if (preco <= 0)
            {
            throw new ArgumentException("Preço invalido, não pode ser zero ou nulo.");
            }
        }
    }
