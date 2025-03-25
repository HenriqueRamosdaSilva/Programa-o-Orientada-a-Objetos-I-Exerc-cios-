using System;
public interface IVoar
{
    void Voar();
}
public interface INadar
{
    void Nadar();
}
public class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("Pato está voando");
    }
    public void Nadar()
    {
        Console.WriteLine("Pato está Nadando");
    }
}
public class Aguia : IVoar
{
    public void Voar()
        {
        Console.WriteLine("Águia está voando");
        }
}
public class Peixe :  INadar
{
    public void Nadar()
    {
    Console.WriteLine("Peixe está Nadando");
    }
}

class Program
{
    static void Main()
    {
        IVoar patovoando = new Pato();
        INadar patonadando = new Pato();
        Console.WriteLine("Ação do Pato");
        patovoando.Voar();
        patonadando.Nadar();
        IVoar aguiavoando = new Aguia();
        Console.WriteLine("Ação da Aguia");
        aguiavoando.Voar();
        INadar peixenadando = new Peixe();
        Console.WriteLine("Ação do Peixe");
        peixenadando.Nadar();
    }
}
