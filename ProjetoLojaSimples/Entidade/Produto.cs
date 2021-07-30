using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLojaSimples.Entidade
{
    public class Produto
    {
        //public Produto()
        //{
        //}
        /*  public Produto (string Nome, double Valor, int Codigo)
          {
              Nome = Nome;
              Valor = Valor;
              Codigo = Codigo;
          }*/

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

    }
}
