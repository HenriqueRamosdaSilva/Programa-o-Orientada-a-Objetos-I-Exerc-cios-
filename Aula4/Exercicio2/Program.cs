using System;
public abstract class Funcionario
{
    public abstract decimal CalcularSalario();
}
public class Gerente : Funcionario {
    private decimal salario;
    public Gerente (decimal salario){
        this.salario = salario;
    }
    public override decimal CalcularSalario()
    {
        return salario + (salario * 0.7m);
    }

}
public class Programador : Funcionario {
    private decimal salario;
    public Programador (decimal salario){
        this.salario = salario;
    }
    public override decimal CalcularSalario()
    {
        return salario + (salario * 0.3m);
    }

}

class Program
{
static void Main()
{
    Funcionario gerente = new Gerente (10000m);
    Funcionario programador = new Programador (4000m);

    Console.WriteLine ("Salario do Gerente" + gerente.CalcularSalario());
    Console.WriteLine ("Salario do Programador" + programador.CalcularSalario());

}
}