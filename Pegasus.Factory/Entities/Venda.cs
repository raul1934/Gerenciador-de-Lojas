using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
    public class Venda
    {
        public virtual int Id { get; set; }
        public virtual IList<ProdutoVenda> produtos { get; set; }
        public virtual DateTime dtFinalizacao { get; set; }
        public virtual int formaPagamento { get; set; }
        public virtual Decimal total { get; set; }
        public virtual Decimal desconto { get; set; }
        public virtual Funcionario funcionario { get; set; }
        public virtual decimal subtotal { get; set; }
        public virtual bool pagamentoAVista { get; set; }
        public virtual Cliente cliente { get; set; }

        public Venda()
        {
            cliente = new Cliente();
            funcionario = new Funcionario();
            produtos = new List<ProdutoVenda>();

        }
    }
}
