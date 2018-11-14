using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
    public class Produto
    {
        public virtual int id { get; set; }
        public virtual string descricao { get; set; }
        public virtual string especificacao { get; set; }
        public virtual Marca marca { get; set; }
        public virtual string codigoBarras { get; set; }
        public virtual string codInterno { get; set; }
        public virtual Boolean servico { get; set; }
        public virtual DateTime dataInicio { get; set; }
        public virtual DateTime dataFim { get; set; }
        public virtual Boolean ativo { get; set; }
        public virtual Categoria categoria { get; set; }
        public virtual SubCategoria subcategoria { get; set; }
        public virtual Fornecedor fornecedor { get; set; }
        public virtual Boolean naoControlarEstoque { get; set; }
        public virtual double qtdProdutoVenda { get; set; }
        public virtual byte[] imagem { get; set; }
        public virtual Decimal peso { get; set; }
        public virtual Decimal largura { get; set; }
        public virtual Decimal altura { get; set; }
        public virtual Decimal comprimento { get; set; }
        public virtual IList<ProdutoPreco> preco { get; set; }
        public virtual IList<ProdutoEstoque> estoque { get; set; }
        public virtual int estoquemin { get; set; }
        public virtual string corredor { get; set; }
        public virtual string prateleira { get; set; }
        public virtual string unidadeMedida { get; set; }

        public Produto()
        {
            fornecedor = new Fornecedor();
            categoria = new Categoria();
            subcategoria = new SubCategoria();
            marca = new Marca();
            preco = new List<ProdutoPreco>();
            estoque = new List<ProdutoEstoque>();
        }

       
    }

}
