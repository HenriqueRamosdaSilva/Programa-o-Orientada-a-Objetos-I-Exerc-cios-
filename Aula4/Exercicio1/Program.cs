using System;
public abstract class Pagamento
{
    public virtual void ProcessarPagamento(){
        Console.WriteLine("Processando pagamento");
    }
}
public class CartaoCredito : Pagamento{
    public override void ProcessarPagamento(){
        Console.WriteLine("Pagamento realizado por Cartao de Credito");
    }
}
public class BoletoBancario : Pagamento{
    public override void ProcessarPagamento(){
        Console.WriteLine("Pagamento realizado por Boleto Bancario");
    }
}
public class Pix : Pagamento{
    public override void ProcessarPagamento(){
        Console.WriteLine("Pagamento realizado por Pix");
    }
}
class Program
{
static void Main()
{
    Pagamento[] pagamentos = new Pagamento[3];

    pagamentos[0] = new CartaoCredito();
    pagamentos[1] = new BoletoBancario();
    pagamentos[2] = new Pix();

    foreach (var pagamento in pagamentos){
        pagamento.ProcessarPagamento();
    }

}
}