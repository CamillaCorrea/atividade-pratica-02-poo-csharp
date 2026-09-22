class Program
{
    static void Main()
    {
        List<Curso> cursos = new List<Curso>();
        int menu = 0;
        while (menu != 3)
        {
            Console.WriteLine("1 - Cadastrar curso");
            Console.WriteLine("2 - Listar cursos");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("4 - Ver cursos disponíveis");
            Console.Write("Opção escolhida: ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Curso curso = new Curso();
                Console.Write("Nome: ");
                curso.Nome = Console.ReadLine();
                Console.Write("Carga horária: ");
                curso.CargaHoraria = Convert.ToInt32(Console.ReadLine());
                Console.Write("Professor: ");
                curso.Professor = Console.ReadLine();
                Console.Write("Modalidade: ");
                curso.Modalidade = Console.ReadLine();
                Console.Write("Quantidade de vagas: ");
                curso.QuantidadeVagas = Convert.ToInt32(Console.ReadLine());
                cursos.Add(curso);
                Console.WriteLine("Curso cadastrado!\n");
            }
            else if (menu == 2)
            {
                foreach (Curso curso in cursos)
                    curso.MostrarCurso();
            }
            else if (menu == 4)
            {
                Console.WriteLine("\nCURSOS DISPONÍVEIS");
                foreach (Curso curso in cursos)
                    if (curso.QuantidadeVagas > 0)
                        curso.MostrarCurso();
            }
        }
    }
}
