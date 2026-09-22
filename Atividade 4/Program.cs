class Program
{
    static void Main()
    {
        List<Veiculo> veiculos = new List<Veiculo>();
        int menu = 0;
        while (menu != 3)
        {
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Listar veículos");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("4 - Pesquisar veículo");
            Console.Write("Opção escolhida: ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Veiculo veiculo = new Veiculo();
                Console.Write("Marca: ");
                veiculo.Marca = Console.ReadLine();
                Console.Write("Modelo: ");
                veiculo.Modelo = Console.ReadLine();
                Console.Write("Ano: ");
                veiculo.Ano = Convert.ToInt32(Console.ReadLine());
                Console.Write("Cor: ");
                veiculo.Cor = Console.ReadLine();
                Console.Write("Placa: ");
                veiculo.Placa = Console.ReadLine();
                veiculos.Add(veiculo);
                Console.WriteLine("Veículo cadastrado!\n");
            }
            else if (menu == 2)
            {
                foreach (Veiculo veiculo in veiculos)
                    veiculo.MostrarVeiculo();
            }
            else if (menu == 4)
            {
                Console.Write("Digite a marca ou modelo: ");
                string pesquisa = Console.ReadLine().ToLower();
                foreach (Veiculo veiculo in veiculos)
                    if (veiculo.Marca.ToLower().Contains(pesquisa) || veiculo.Modelo.ToLower().Contains(pesquisa))
                        veiculo.MostrarVeiculo();
            }
        }
    }
}
