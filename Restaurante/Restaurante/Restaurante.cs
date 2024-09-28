public class Restaurante()
{
    private Mesa mesaReservada = new Mesa();
    private Pedido Pedidos = new Pedido();
    public Mesa NumMesa { get; set; }
    public Cardapio Pedido { get; set; }

    public void MesaReservada()
    {

        if (mesaReservada.NumMesa == 0)
        {
            Console.WriteLine("Mesa reservada com sucesso");
            mesaReservada.NumMesa += 1;
        }
        else {
            Console.WriteLine("Essa mesa já esta reservada");
        }
    }

    public void PedidosDisponiveis()
    {

        Console.WriteLine($"Pratos disponíveis: {Pedidos.pedidos}");
    }
}