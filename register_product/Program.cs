using register_product.Modelo;

namespace register_product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();
            Menu(estoque);
        }

        //Função para criar o Menu
        static void Menu(Estoque estoque)
        {
            
            Console.WriteLine("Bem vindo! Selecione a uma das opções abaixo:");
            Console.WriteLine("(1) - Cadastrar um novo produto.");
            Console.WriteLine("(2) - Verificar Valor do Estoque.");
            Console.WriteLine("(3) - Verificar Quantidade do Estoque.");
            Console.WriteLine("(4) - Exibir o Estoque.");
            Console.WriteLine("(5) - Finalizar programa.");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 5: System.Environment.Exit(0); break;
                case 1: CadastrarProduto(estoque); break;
                case 2: VerificarValorEstoque(estoque); break;
                case 3: VerificarQuantidadeEstoque(estoque); break;
                case 4: ExibirEstoque(estoque); break;
                default: Menu(estoque); break;

            }
        }

        //Função para cadastrar/solicitar informações do produto
        static void CadastrarProduto(Estoque estoque)
        {
            Console.Clear();

            string nome;
            double valor;
            int quantidade;

            Console.WriteLine("Informar o nome do produto:");
            nome = Console.ReadLine();

            Console.WriteLine("Informar o valor do produto:");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade dos produtos cadastrados:");
            quantidade = int.Parse(Console.ReadLine());

             //Construtor criando produto + adicionando ele a lista
            Produto produto = new Produto(nome, valor, quantidade);
            estoque.AdicionarProduto(produto);

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Menu(estoque);

        }

        //Função para mostrar o valor total estoque
        static void VerificarValorEstoque(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-- Valor total do estoque --");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("O Valor total do estoque é: " + estoque.ValorTotal());
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Menu(estoque);
        }

        //Função para mostrar a quantidade de produtos em estoque
        static void VerificarQuantidadeEstoque(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-- Quantidade total do estoque --");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("A quantidade do estoque é: " + estoque.Quantidade());
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Menu(estoque);
        }

        //Função para mostrar os detalhes dos produtos em estoque (apenas chamar a função)
        static void ExibirEstoque(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("-- Detalhes do Estoque --");
            Console.WriteLine("-------------------------");
            estoque.ExibirProdutos();
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Menu(estoque);
        }
    }
}
