class Musica
{
    public int Codigo;
    public string Titulo;
    public string Cantor;
    public string Genero;
    public int Ano;
    public int Duracao;

    public void MostrarMusica()
    {
        Console.WriteLine("Código: " + Codigo);
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Cantor ou banda: " + Cantor);
        Console.WriteLine("Gênero: " + Genero);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Duração: " + Duracao + " minutos");
        Console.WriteLine();
    }
}
