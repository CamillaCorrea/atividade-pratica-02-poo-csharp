class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();
        int menu = 0;

        while (menu != 3)
        {
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção escolhida: ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Produto produto = new Produto();
                Console.Write("Nome: ");
                produto.Nome = Console.ReadLine();
                Console.Write("Categoria: ");
                produto.Categoria = Console.ReadLine();
                Console.Write("Preço: ");
                produto.Preco = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade: ");
                produto.Quantidade = Convert.ToInt32(Console.ReadLine());
                produtos.Add(produto);
                Console.WriteLine("Produto cadastrado!\n");
            }
            else if (menu == 2)
            {
                Console.WriteLine("\nPRODUTOS CADASTRADOS");
                foreach (Produto produto in produtos)
                    produto.MostrarProduto();
            }
        }
    }
}
