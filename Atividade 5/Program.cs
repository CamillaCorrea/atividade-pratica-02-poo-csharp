class Program
{
    static void Main()
    {
        List<Filme> filmes = new List<Filme>();
        int menu = 0;
        while (menu != 3)
        {
            Console.WriteLine("1 - Cadastrar filme");
            Console.WriteLine("2 - Listar filmes");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção escolhida: ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Filme filme = new Filme();
                Console.Write("Título: ");
                filme.Titulo = Console.ReadLine();
                Console.Write("Gênero: ");
                filme.Genero = Console.ReadLine();
                Console.Write("Ano: ");
                filme.Ano = Convert.ToInt32(Console.ReadLine());
                Console.Write("Duração em minutos: ");
                filme.Duracao = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nota: ");
                filme.Nota = Convert.ToDouble(Console.ReadLine());
                filmes.Add(filme);
                Console.WriteLine("Filme cadastrado!\n");
            }
            else if (menu == 2)
            {
                foreach (Filme filme in filmes)
                    filme.ExibirInformacoes();
            }
        }
    }
}
