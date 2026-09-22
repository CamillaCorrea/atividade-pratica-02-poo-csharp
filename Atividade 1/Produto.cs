class Produto
{
    public string Nome;
    public string Categoria;
    public double Preco;
    public int Quantidade;

    public void MostrarProduto()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Categoria: " + Categoria);
        Console.WriteLine("Preço: " + Preco.ToString("C"));
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine("Valor total em estoque: " + (Preco * Quantidade).ToString("C"));
        Console.WriteLine();
    }
}
