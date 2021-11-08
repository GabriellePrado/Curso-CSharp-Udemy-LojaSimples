using ProjetoLojaSimples.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLojaSimples.Negocio
{
    public class ProdutoService
    {
        Produto _produto = new Produto();
        public double CalculaTotalCompra()
        {
            double total = 0.0;
            foreach (Produto obj in _produto.CarrinhoCompras)
            {
                
                total += obj.Quantidade * obj.Valor;
            }
            return total;
        }

        public void AdicionaProdutoCarrinho(Produto produto)
        {
            _produto.CarrinhoCompras.Add(produto);
        }
        public List<Produto> ListaCarrinhoCompras()
        {
            return _produto.CarrinhoCompras;
        }

            public void AdicionaProduto(Produto produto)
        {
            _produto.ListaProdutos.Add(produto);
        }
        public List<Produto> ListaProdutos()
        {
            AdicionaProduto(new Produto("Coca", 5.0, 1));
            AdicionaProduto(new Produto("Café", 2.0, 2));
            AdicionaProduto(new Produto("Maça", 2.50, 3));
            AdicionaProduto(new Produto("Sal", 10.0, 4));
            AdicionaProduto(new Produto("Arroz", 5.0, 5));
            
            return _produto.ListaProdutos;
        }

        public bool ValidaCompra(int quantidade)
        {
            if (quantidade > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
