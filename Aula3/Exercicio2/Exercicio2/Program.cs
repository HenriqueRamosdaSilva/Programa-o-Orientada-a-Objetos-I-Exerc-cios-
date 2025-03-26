using System;

class Program{
    static void Main(){
        Item item = new Item("Camiseta", 69.99);
        Pedido pedido = new Pedido(item);

        pedido.ExibirPedido();
    }



}