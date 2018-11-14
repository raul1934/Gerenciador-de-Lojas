using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
   public class ProdutoVendaMap : ClassMap<ProdutoVenda>
    {
        public ProdutoVendaMap()
        {
            
            Table("tblprodutovendaproduto");
            
            Id(produtovenda => produtovenda.id).GeneratedBy.Identity();
            Map(produtovenda => produtovenda.quantidade);
            Map(produtovenda => produtovenda.desconto);
            References(produtovenda => produtovenda.produto)
                .Nullable()
                .Not
                .LazyLoad()
                .Cascade
                .None();
        }
    }
}
