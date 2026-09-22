class Program
{
    static void Main()
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        int menu = 0;
        while (menu != 3)
        {
            Console.WriteLine("1 - Cadastrar funcionário");
            Console.WriteLine("2 - Listar funcionários");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção escolhida: ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Funcionario funcionario = new Funcionario();
                Console.Write("Nome: ");
                funcionario.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                funcionario.Idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Cargo: ");
                funcionario.Cargo = Console.ReadLine();
                Console.Write("Salário: ");
                funcionario.Salario = Convert.ToDouble(Console.ReadLine());
                Console.Write("Setor: ");
                funcionario.Setor = Console.ReadLine();
                funcionarios.Add(funcionario);
                Console.WriteLine("Funcionário cadastrado!\n");
            }
            else if (menu == 2)
            {
                foreach (Funcionario funcionario in funcionarios)
                    funcionario.Apresentar();
            }
        }
    }
}
