class Program
{
    static void Main()
    {
        List<Pedido> pedidos = new List<Pedido>();
        int menu = 0;
        while (menu != 3)
        {
            Console.WriteLine("1 - Cadastrar pedido");
            Console.WriteLine("2 - Listar pedidos");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção escolhida: ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Pedido pedido = new Pedido();
                Console.Write("Número: ");
                pedido.Numero = Console.ReadLine();
                Console.Write("Cliente: ");
                pedido.Cliente = Console.ReadLine();
                Console.Write("Produto: ");
                pedido.Produto = Console.ReadLine();
                Console.Write("Quantidade: ");
                pedido.Quantidade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Valor unitário: ");
                pedido.ValorUnitario = Convert.ToDouble(Console.ReadLine());
                pedidos.Add(pedido);
                Console.WriteLine("Pedido cadastrado!\n");
            }
            else if (menu == 2)
            {
                foreach (Pedido pedido in pedidos)
                    pedido.MostrarPedido();
            }
        }
    }
}
