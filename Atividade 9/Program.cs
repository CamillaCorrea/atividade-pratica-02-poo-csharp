class Program
{
    static void Main()
    {
        List<Equipamento> equipamentos = new List<Equipamento>();
        int menu = 0;
        while (menu != 4)
        {
            Console.WriteLine("1 - Cadastrar equipamento");
            Console.WriteLine("2 - Listar equipamentos");
            Console.WriteLine("3 - Pesquisar equipamento");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("5 - Equipamentos em manutenção");
            Console.Write("Opção escolhida: ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Equipamento equipamento = new Equipamento();
                Console.Write("Patrimônio: ");
                equipamento.Patrimonio = Console.ReadLine();
                Console.Write("Tipo: ");
                equipamento.Tipo = Console.ReadLine();
                Console.Write("Marca: ");
                equipamento.Marca = Console.ReadLine();
                Console.Write("Modelo: ");
                equipamento.Modelo = Console.ReadLine();
                Console.Write("Número de série: ");
                equipamento.NumeroSerie = Console.ReadLine();
                Console.Write("Status (Disponível, Em uso ou Manutenção): ");
                equipamento.Status = Console.ReadLine();
                equipamentos.Add(equipamento);
                Console.WriteLine("Equipamento cadastrado!\n");
            }
            else if (menu == 2)
            {
                foreach (Equipamento equipamento in equipamentos)
                    equipamento.MostrarEquipamento();
            }
            else if (menu == 3)
            {
                Console.Write("Digite o patrimônio ou modelo: ");
                string pesquisa = Console.ReadLine().ToLower();
                foreach (Equipamento equipamento in equipamentos)
                    if (equipamento.Patrimonio.ToLower().Contains(pesquisa) || equipamento.Modelo.ToLower().Contains(pesquisa))
                        equipamento.MostrarEquipamento();
            }
            else if (menu == 5)
            {
                foreach (Equipamento equipamento in equipamentos)
                    if (equipamento.Status.ToLower() == "manutenção" || equipamento.Status.ToLower() == "manutencao")
                        equipamento.MostrarEquipamento();
            }
        }
    }
}
