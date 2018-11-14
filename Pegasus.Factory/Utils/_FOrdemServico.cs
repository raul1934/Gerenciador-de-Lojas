using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Utils
{
    public static class _FOrdemServico
    {
        public static decimal getTotal(OrdemServico os)
        {
            decimal d = 0m;

            foreach (ProdutoVenda produto in os.produtos)
            {
                if (os.pagamentoAPrazo)
                {
                    d += produto.produto.preco.Last().precoVendaPrazo * produto.quantidade;
                }
                else
                {
                    d += produto.produto.preco.Last().precoVendaVista * produto.quantidade;
                }

            }
            return d;
        }

        public static decimal getDesconto(OrdemServico os)
        {
            decimal d = 0m;

            foreach (ProdutoVenda produto in os.produtos)
            {
                d += produto.desconto;
            }
            return d;
        }
    }
}
