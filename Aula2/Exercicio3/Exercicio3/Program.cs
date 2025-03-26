
﻿using System;

class Elevador{
    private int _andarAtual;
    private int totalAndares;
    
    public Elevador( int totalAndares){
        this._andarAtual = 0;
        this.totalAndares = totalAndares;
    }
    public int AndarAtual {
        get { return _andarAtual; } // Retorna o saldo
        set{
            if (value >= 0 && value <= totalAndares)
                _andarAtual = value;
            else
                Console.WriteLine("Andar Inválido");
        }
    }
    public void Subir(){
        if(_andarAtual < totalAndares)
        {
            _andarAtual++;
        }
        else{
            Console.WriteLine("Ultimo Andar");
        }
    }
    public void Descer(){
        if(_andarAtual > 0)
        {
           _andarAtual--;
        }
        else{
            Console.WriteLine("Primeiro Andar");
        }
    }

}

class Program{
static void Main()
{
    Elevador e = new Elevador(10); // 10 andares
    e.Subir();
    e.Subir();
    Console.WriteLine(e.AndarAtual); // Deve exibir 2
    e.Descer();
    Console.WriteLine(e.AndarAtual); // Deve exibir 1
    e.Descer();
    e.Descer(); // Deve continuar em 0

}
}
