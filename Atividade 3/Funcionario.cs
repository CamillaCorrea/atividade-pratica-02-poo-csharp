class Funcionario
{
    public string Nome;
    public int Idade;
    public string Cargo;
    public double Salario;
    public string Setor;

    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    public void Apresentar()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Setor: " + Setor);
        Console.WriteLine("Salário: " + Salario.ToString("C"));
        Console.WriteLine("Salário anual: " + CalcularSalarioAnual().ToString("C"));
        Console.WriteLine();
    }
}
