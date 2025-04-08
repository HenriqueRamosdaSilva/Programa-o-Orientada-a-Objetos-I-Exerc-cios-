using System;

class Program{
    static void Main()
    {
        Console.WriteLine("Digite uma frase com espaços no início e no fim, e com palavras separadas por vírgulas ");
        string frase = Console.ReadLine();
        string fraseTrim = frase.Trim();
        Console.WriteLine("Sem os espaços extras da frase:"+ fraseTrim );
        string [] fraseSplit =frase.Split(','); 
        Console.WriteLine("Frase dividida em partes: ");
        foreach (string palavra in fraseSplit){
            Console.WriteLine(palavra.Trim());
        }
        Console.WriteLine("Digite a palavra que você deseja substituir:");
        string palavraAntiga = Console.ReadLine();
        Console.WriteLine("Digite a palavra nova para substituir:");
        string palavraNova = Console.ReadLine();

        frase = frase.Replace(palavraAntiga, palavraNova);
        Console.WriteLine("Frase após substituição: " + frase);

        Console.WriteLine("Digite a palavra que deseja verificar, se a frase começa com determinada palavra: " );
        string palavraComeca = Console.ReadLine().Trim();

        if (frase.Trim().StartsWith(palavraComeca))
        {
            Console.WriteLine("A frase começa com a palavra '" + palavraComeca);
        }
        else
        {
            Console.WriteLine("A frase NÃO começa com a palavra '" + palavraComeca);
        }
        Console.WriteLine("Digite a palavra que deseja verificar, se a frase termina com determinada palavra: " );
        string palavraTermina = Console.ReadLine().Trim();
         if (frase.Trim().EndsWith(palavraTermina))
        {
            Console.WriteLine("A frase termina com a palavra '" + palavraTermina);
        }
        else
        {
            Console.WriteLine("A frase NÃO termina com a palavra '" + palavraTermina);
        }
    }
}