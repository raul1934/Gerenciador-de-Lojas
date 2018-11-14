using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
        /*  Em Aberto
            Finalizado
            Cancelado
            Aguardando Pagamento
        */
    public class OrdemServico
    {
        public virtual int id { get; set; }
        public virtual DateTime dataInicio { get; set; }
        public virtual DateTime dataFim { get; set; }
        public virtual double desconto  { get; set; }
        public virtual Boolean pagamentoAPrazo { get; set; }
        public virtual int situacao { get; set; }
        public virtual string datapagamentoAPrazo { get; set; }
        public virtual string defeitoRelatado { get; set; }
        public virtual string defeitoConstatado { get; set; }
        public virtual string servicosRealizados { get; set; }
        public virtual string observacoes { get; set; }
        public virtual IList<ProdutoVenda> produtos { get; set; }
        public virtual Cliente cliente { get; set; }
        public virtual Funcionario funcionario { get; set; }

        public OrdemServico()
        {
            cliente = new Cliente();
            produtos = new List<ProdutoVenda>();
            funcionario = new Funcionario();
        }
    }
}
