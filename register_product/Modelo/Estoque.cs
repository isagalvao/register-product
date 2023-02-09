using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace register_product.Modelo
{
    internal class Estoque
    {

        //lista para armazenar os Produtos
        public List<Produto> Produtos { get; set; }

        //Construtor para criar a lista de produtos em estoque
        public Estoque()
        {
           Produtos = new List<Produto>();
        }
        //Função para adicionar os Produtos a lista
        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        //Função para calcular o valor Total dos produtos em estoque
        public double ValorTotal()
        {
            double total = 0;

            Produtos.ForEach(produto =>
            {
                total = total + produto.Valor * produto.Quantidade;

            });

            return total;
        }

        //Função para calcular a quantidade de produtos em estoque
        public int Quantidade()
        {
            int soma = 0;

            Produtos.ForEach(produto =>
            {
                soma = soma + produto.Quantidade;
            });

            return soma;
        }

        //Função para exibir produtos em estoque
        public void ExibirProdutos()
        {
            Produtos.ForEach(produto =>
            {
                Console.WriteLine(produto.ToString() + "\n");
            });
        }
    }
}
