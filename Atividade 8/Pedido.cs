class Pedido
{
    public string Numero;
    public string Cliente;
    public string Produto;
    public int Quantidade;
    public double ValorUnitario;

    public double CalcularTotal()
    {
        return Quantidade * ValorUnitario;
    }

    public void MostrarPedido()
    {
        Console.WriteLine("Pedido: " + Numero);
        Console.WriteLine("Cliente: " + Cliente);
        Console.WriteLine("Produto: " + Produto);
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine("Valor unitário: " + ValorUnitario.ToString("C"));
        Console.WriteLine("Total: " + CalcularTotal().ToString("C"));
        Console.WriteLine();
    }
}
