class Program
{
    static void Main()
    {
        List<Musica> musicas = new List<Musica>();
        int menu = 0;

        while (menu != 7)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("CADASTRO DE MÚSICAS");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Pesquisar");
            Console.WriteLine("4 - Alterar");
            Console.WriteLine("5 - Excluir");
            Console.WriteLine("6 - Relatório");
            Console.WriteLine("7 - Sair");
            Console.Write("Digite a opção: ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Musica musica = new Musica();
                Console.Write("Código: ");
                musica.Codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Título: ");
                musica.Titulo = Console.ReadLine();
                Console.Write("Cantor ou banda: ");
                musica.Cantor = Console.ReadLine();
                Console.Write("Gênero: ");
                musica.Genero = Console.ReadLine();
                Console.Write("Ano: ");
                musica.Ano = Convert.ToInt32(Console.ReadLine());
                Console.Write("Duração em minutos: ");
                musica.Duracao = Convert.ToInt32(Console.ReadLine());
                musicas.Add(musica);
                Console.WriteLine("Música cadastrada!\n");
            }
            else if (menu == 2)
            {
                foreach (Musica musica in musicas)
                    musica.MostrarMusica();
            }
            else if (menu == 3)
            {
                Console.Write("Digite o título da música: ");
                string titulo = Console.ReadLine().ToLower();
                foreach (Musica musica in musicas)
                    if (musica.Titulo.ToLower().Contains(titulo))
                        musica.MostrarMusica();
            }
            else if (menu == 4)
            {
                Console.Write("Código da música: ");
                int codigo = Convert.ToInt32(Console.ReadLine());
                Musica encontrada = null;
                foreach (Musica musica in musicas)
                    if (musica.Codigo == codigo)
                        encontrada = musica;

                if (encontrada != null)
                {
                    Console.Write("Novo título: ");
                    encontrada.Titulo = Console.ReadLine();
                    Console.Write("Novo cantor ou banda: ");
                    encontrada.Cantor = Console.ReadLine();
                    Console.WriteLine("Música alterada!\n");
                }
                else
                    Console.WriteLine("Música não encontrada.\n");
            }
            else if (menu == 5)
            {
                Console.Write("Código da música: ");
                int codigo = Convert.ToInt32(Console.ReadLine());
                Musica encontrada = null;
                foreach (Musica musica in musicas)
                    if (musica.Codigo == codigo)
                        encontrada = musica;

                if (encontrada != null)
                {
                    musicas.Remove(encontrada);
                    Console.WriteLine("Música excluída!\n");
                }
                else
                    Console.WriteLine("Música não encontrada.\n");
            }
            else if (menu == 6)
            {
                Console.WriteLine("Total de músicas: " + musicas.Count);
                int recentes = 0;
                foreach (Musica musica in musicas)
                    if (musica.Ano >= 2020)
                        recentes++;
                Console.WriteLine("Músicas lançadas a partir de 2020: " + recentes + "\n");
            }
        }
    }
}
