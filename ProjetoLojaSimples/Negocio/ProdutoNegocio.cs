using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLojaSimples.Negocio
{
    public class ProdutoNegocio
    {
        public double CalculaTotalCompra(int quantidade, double valor)
        {
            double total = 0.0;
            total = quantidade * valor;

            return total;
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
