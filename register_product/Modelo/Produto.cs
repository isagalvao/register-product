using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace register_product.Modelo
{
    internal class Produto
    {
        //Função para registra produto
        public Produto(string nome, double valor, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        //Estudar mais GET SET **Duvida**
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        //Função para mostrar os detalhes dos produtos em estoque
        public override string ToString()
        {
            return "Nome do produto:" + Nome + " " + "Valor do produto:" + Valor + " " + "Quantidade em estoque:" + Quantidade;
        }
    }
}
