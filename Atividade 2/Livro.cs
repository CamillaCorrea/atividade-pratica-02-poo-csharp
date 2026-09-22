class Livro
{
    public string Titulo;
    public string Autor;
    public int Ano;
    public string Categoria;
    public bool Disponivel;

    public void MostrarLivro()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Categoria: " + Categoria);
        if (Disponivel)
            Console.WriteLine("Situação: DISPONÍVEL");
        else
            Console.WriteLine("Situação: EMPRESTADO");
        Console.WriteLine();
    }
}
