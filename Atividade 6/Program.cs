class Program
{
    static void Main()
    {
        List<Cliente> clientes = new List<Cliente>();
        int menu = 0;
        while (menu != 4)
        {
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Listar clientes");
            Console.WriteLine("3 - Pesquisar cliente");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção escolhida: ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Cliente cliente = new Cliente();
                Console.Write("Nome: ");
                cliente.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                cliente.Idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Cidade: ");
                cliente.Cidade = Console.ReadLine();
                Console.Write("E-mail: ");
                cliente.Email = Console.ReadLine();
                Console.Write("Telefone: ");
                cliente.Telefone = Console.ReadLine();
                clientes.Add(cliente);
                Console.WriteLine("Cliente cadastrado!\n");
            }
            else if (menu == 2)
            {
                foreach (Cliente cliente in clientes)
                    cliente.ApresentarCliente();
            }
            else if (menu == 3)
            {
                Console.Write("Digite o nome do cliente: ");
                string nome = Console.ReadLine().ToLower();
                foreach (Cliente cliente in clientes)
                    if (cliente.Nome.ToLower().Contains(nome))
                        cliente.ApresentarCliente();
            }
        }
    }
}
