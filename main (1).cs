/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
public class Pessoa {/*Classe*/
    public string Nome;/*Atributo*/
    public int Idade;/*Atributo*/
    public string Cargo;/*Atributo*/
    
    public void Apresentar(){
        Console.WriteLine($"Olá, meu nome é { Nome }, tenho { Idade } anos e sou {Cargo}.");
    }
    public void Salario(){
        if(Cargo == "Estagiário"){
            Console.WriteLine($"R$ 100,00.");
        }
        else if (Cargo == "Desenvolvedor"){
            Console.WriteLine($" R$5000,00.");
        }
        else{
            Console.WriteLine($" R$10.000,00.");
        
        }
    }
}
public class Program{
    public static void Main(){
        Pessoa p1 = new Pessoa();/*Objeto*/
        p1.Idade = 30;
        p1.Nome = "João";
        p1.Cargo = "Gerente";
        p1.Apresentar();/*Metodo*/
        p1.Salario();
        
         Pessoa p2 = new Pessoa();/*Objeto*/
        p2.Idade = 27;
        p2.Nome = "Paulo";
        p2.Cargo = "Desenvolvedor";
        p2.Apresentar();/*Metodo*/
        p2.Salario();
        
         Pessoa p3 = new Pessoa();/*Objeto*/
        p3.Idade = 21;
        p3.Nome = "Caio";
        p3.Cargo = "Estagiário";
        p3.Apresentar();/*Metodo*/
        p3.Salario();
    } 
}