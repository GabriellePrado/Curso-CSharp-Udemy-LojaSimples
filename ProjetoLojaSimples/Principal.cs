using ProjetoLojaSimples.Entidade;
using ProjetoLojaSimples.Negocio;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoLojaSimples
{
    class Principal
    {
        static void Main(string[] args)
        {
            var lista = ListaDeProdutos();

            double total = 0;

            Produto prod = new Produto();
            ProdutoNegocio negocio = new ProdutoNegocio();

            Console.WriteLine(" Bem Vindo!\n\n");
            foreach (var listagem in lista)
            {
                // Console.WriteLine("Produto: " + listagem.Nome + " Código: " + listagem.Codigo + " Valor: " + listagem.Valor.ToString("F2"), CultureInfo.InvariantCulture);

                Console.WriteLine("Código: {0}  | Produto: {1}  | Valor: {2} ", listagem.Codigo, listagem.Nome, listagem.Valor.ToString("F2"), CultureInfo.InvariantCulture);
            }


            Console.WriteLine("\nDigite o Código do Produto: ");
            prod.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Confirme o nome e valor do produto: ");
            // apresentar o nome com o valor do produto atráves da chamada da lista 
            Console.WriteLine(" Digite a quantidade que deseja comprar: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------");

            if (negocio.ValidaCompra(prod.Quantidade))
            {
                total = negocio.CalculaTotalCompra(prod.Quantidade, prod.Valor);
                Console.WriteLine($"Total da compra: {total.ToString("F2", CultureInfo.InvariantCulture)} \n Obrigado volte sempre !");
            }
            else
            {
                Console.WriteLine("Nenhuma compra foi feita.");
            }
        }
        /* public static void CriarProduto(string nome, double valor, int codigo)
         {
             Produto prod = new Produto { Nome = nome, Valor = valor, Codigo = codigo };
             ListaDeProdutos(prod);
         }*/

        public static List<Produto> ListaDeProdutos()
        {
            List<Produto> listandoProduto = new List<Produto>();
            listandoProduto.Add(new Produto() { Nome = "Batata-Frita", Valor = 9.5, Codigo = 1 });
            listandoProduto.Add(new Produto() { Nome = "Coca-Cola", Valor = 8.0, Codigo = 2 });
            return listandoProduto;
        }
    }
}
