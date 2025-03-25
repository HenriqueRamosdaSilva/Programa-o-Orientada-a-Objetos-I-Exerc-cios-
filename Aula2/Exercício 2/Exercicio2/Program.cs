using System;

class Carro{
    private string modelo;
    private int _velocidadeAtual;
    
    public Carro(string modelo , int velocidadeAtual){
        this.modelo = modelo;
        this._velocidadeAtual = velocidadeAtual;
    }
    public int VelocidadeAtual {
        get { return _velocidadeAtual; } // Retorna o saldo
        set{
            if (value < 0)
                _velocidadeAtual = 0;
            else
                _velocidadeAtual = value;
        }
    }
    public void Acelerar(int valor){
        VelocidadeAtual += valor;
    }
    public void Frear(int valor){
        VelocidadeAtual -= valor;
    }

}

class Program{
static void Main()
{
Carro c = new Carro("Ferrari" , 0);
c.Acelerar(50);
Console.WriteLine(c.VelocidadeAtual); // Deve exibir 50
c.Frear(30);
Console.WriteLine(c.VelocidadeAtual); // Deve exibir 20
c.Frear(50); // Não pode ficar negativo, deve exibir 0
Console.WriteLine(c.VelocidadeAtual); // Deve exibir 0

}
}
