class Cliente
{
    public string Nome;
    public int Idade;
    public string Cidade;
    public string Email;
    public string Telefone;

    public void ApresentarCliente()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Cidade: " + Cidade);
        Console.WriteLine("E-mail: " + Email);
        Console.WriteLine("Telefone: " + Telefone);
        Console.WriteLine();
    }
}
