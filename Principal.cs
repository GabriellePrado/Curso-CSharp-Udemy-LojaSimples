using ProjetoLojaSimples.Entidade;
using ProjetoLojaSimples.Negocio;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoLojaSimples
{
    public class Principal
    {

        public static void Main(string[] args)
        {

            ProdutoService service = new ProdutoService();
            List<Produto> listaProdutos = service.ListaProdutos();
            List<Produto> listaCarrinho = service.ListaCarrinhoCompras();
            ProdutoService negocio = new ProdutoService();
            string resposta;
            bool enquanto = true;
            while (enquanto)
            {
                while (enquanto)
                {
                    Console.Clear();
                    Console.WriteLine(" Bem Vindo!\n\n");
                    foreach (Produto listagem in listaProdutos)
                {
                    Console.WriteLine("Código: {0}        | Produto: {1}             | Valor: {2} ",
                        listagem.Codigo,
                        listagem.Nome,
                        listagem.Valor.ToString("F2"), CultureInfo.InvariantCulture);
                }
                    
                    Console.WriteLine("\nDigite o Código do Produto: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nDeseja adicionar na sacola ?");
                    resposta = Console.ReadLine();
                    if (resposta == "S" || resposta == "sim" || resposta == "s")
                    {
                        foreach (Produto obj in listaProdutos)
                        {
                            if (obj.Codigo == codigo)
                            {
                                service.AdicionaProdutoCarrinho(new Produto(obj.Nome, obj.Valor, obj.Codigo, quantidade));
                            }
                        }
                        Console.WriteLine("\nDeseja adicionar mais produtos? ");
                        resposta = Console.ReadLine();
                        if (resposta == "S" || resposta == "sim" || resposta == "s")
                        {
                            enquanto = true;
                        }
                        else
                        {
                            enquanto = false;
                        }
                    }
                    
                }
                enquanto = false;

                Console.WriteLine("\nDeseja finalizar compra ?");
                resposta = Console.ReadLine();
                if (resposta == "S" || resposta == "sim" || resposta =="s")
                {
                    Console.WriteLine(" Lista de compras: ");
                    foreach (Produto listagem in listaCarrinho)
                    {
                        Console.WriteLine("Código: {0}        | Produto: {1}             | Valor: {2} ",
                           listagem.Codigo,
                           listagem.Nome,
                           listagem.Quantidade,
                           listagem.Valor.ToString("F2"), CultureInfo.InvariantCulture);
                    }
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Total compra ");
                    Console.WriteLine("\nR$ {0}", service.CalculaTotalCompra());
                    Console.WriteLine("---------------------");
                }
                else
                {
                    enquanto = false;
                }
            }
            enquanto = false;
        }
    }
}
