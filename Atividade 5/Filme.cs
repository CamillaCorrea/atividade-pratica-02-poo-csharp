class Filme
{
    public string Titulo;
    public string Genero;
    public int Ano;
    public int Duracao;
    public double Nota;

    public void ExibirInformacoes()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Gênero: " + Genero);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Duração: " + Duracao + " minutos");
        Console.WriteLine("Nota: " + Nota);
        if (Nota >= 8)
            Console.WriteLine("Filme com nota maior ou igual a 8!");
        Console.WriteLine();
    }
}
