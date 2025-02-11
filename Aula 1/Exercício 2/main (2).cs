/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
public class  Fantasminhas {/*Classe*/
    public string Nick;/*Atributo*/
    public string Habilidade;/*Atributo*/
    public string Cor;/*Atributo*/
public void  GerarFantasma(){
        Console.WriteLine($"{Nick},{Habilidade},{Cor}");
    }
    public void  Mover(string Parametro){
        Console.WriteLine($"{Nick} se moveu para {Parametro}");
    }
}
public class Program{
public static void Main(){
        Fantasminhas p1 = new Fantasminhas();
        p1.Nick = "C+";
        p1.Habilidade = "Invisiilidade";
        p1.Cor = "Vermelho";
        p1.GerarFantasma();
        p1.Mover("Direita");
        
        Fantasminhas p2 = new Fantasminhas();
        p2.Nick = "Java";
        p2.Habilidade = "Bomba de cafeina";
        p2.Cor = "Marom";
        p2.GerarFantasma();
        p2.Mover("Cima");
        
        Fantasminhas p3 = new Fantasminhas();
        p3.Nick = "Python";
        p3.Habilidade = "Super força";
        p3.Cor = "Amarelo";
        p3.GerarFantasma();
        p3.Mover("Esquerda");
        
        Fantasminhas p4 = new Fantasminhas();
        p4.Nick = "Golang";
        p4.Habilidade = "Super velocidade";
        p4.Cor = "Azul";
        p4.GerarFantasma();
        p4.Mover("Baixo");
    }
}
