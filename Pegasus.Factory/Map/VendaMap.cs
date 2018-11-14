using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
  public  class VendaMap  : ClassMap<Venda>
    {
        public VendaMap()
        {
            Table("tblVenda");
            Id(venda=> venda.Id).GeneratedBy.Identity();
            Map(venda => venda.dtFinalizacao);
            Map(venda => venda.formaPagamento);
            Map(venda => venda.pagamentoAVista);
            Map(venda => venda.subtotal);
            Map(venda => venda.total);
            Map(venda => venda.desconto);
            References(venda => venda.cliente)
                .Not
                .LazyLoad()
                .Cascade
                .SaveUpdate();
            References(venda => venda.funcionario)
                .Not
                .LazyLoad()
                .Cascade
                .SaveUpdate();
            HasManyToMany(venda => venda.produtos)
                .Table("tblprodutoVenda")
                .ParentKeyColumn("vendaId")
                .ChildKeyColumn("vendaprodutoid")
                .Not
                .LazyLoad()
                .Cascade.SaveUpdate();


        }
        
    }
}
