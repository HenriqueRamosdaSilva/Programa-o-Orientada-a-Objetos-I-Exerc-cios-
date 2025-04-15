using System;

    class Program{
        static void Main(){
            try
            {
            Console.WriteLine("Digite um numero");
            int numero =int.Parse (Console.ReadLine());
            Console.WriteLine("Numero digitado");
            Console.WriteLine(numero);

            }
            catch ( FormatException)
            {
            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
            }
            finally
            {
            Console.WriteLine("Bloco finally executado.");
            }
            }
        }

    
