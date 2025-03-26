public class Pedido{
    private Item item;

    public Pedido(Item  item){
        this.item=item;
    }
    public void ExibirPedido(){
         Console.WriteLine("Pedido Realizado:");
         item.Exibir();
}
}