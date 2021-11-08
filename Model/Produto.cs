using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProjetoLojaSimples.Entidade
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public List<Produto> ListaProdutos = new List<Produto>();

        public List<Produto> CarrinhoCompras = new List<Produto>();
        public Produto(string nome, double valor, int codigo)
        {
            Nome = nome;
            Valor = valor;
            Codigo = codigo;
        }
        public Produto(string nome, double valor, int codigo, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Codigo = codigo;
            Quantidade = quantidade;
        }
        public Produto()
        {
        }

        public void AdicionaProduto(Produto produto)
        {
            ListaProdutos.Add(produto);
        }

    }
}
