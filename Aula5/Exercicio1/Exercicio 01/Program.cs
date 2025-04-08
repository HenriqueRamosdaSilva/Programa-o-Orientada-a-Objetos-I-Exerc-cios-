using System;

class Program{
    static void Main()
    {
        for(int i = 1 ; i<=5; i++){
        Console.WriteLine("Digite o " + i +"decimal: ");
        double numero =double.Parse (Console.ReadLine());
        Console.WriteLine("O número original:"+ numero);
        double aredondamento = Math.Round(numero);
        Console.WriteLine("O valor com arredondamento padrão: "+ aredondamento);
        double aredondamento_baixo = Math.Floor(numero);
        Console.WriteLine("O valor com arredondamento para baixo: "+ aredondamento_baixo);
        double aredondamento_cima = Math.Ceiling(numero);
        Console.WriteLine("O valor com arredondamento para cima: "+ aredondamento_cima);
        double aredondamento_truncado = Math.Truncate(numero);
        Console.WriteLine("O valor com truncamento: "+ aredondamento_truncado);
        }
    }
}