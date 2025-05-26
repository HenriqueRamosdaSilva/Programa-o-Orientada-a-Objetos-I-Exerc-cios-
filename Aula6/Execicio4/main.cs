using System;
public class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException() : base("Idade mínima para acesso é 18 anos.") 
    {}
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());
             if (idade < 18)
        {
            throw new IdadeInvalidaException();
        }
        else
        {
            Console.WriteLine("Acesso permitido.");
        }
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor, digite um número válido.");
        }
    }
}
