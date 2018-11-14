using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;

namespace Pegasus.Factory.Map
{
   public class OrderServicoMap : ClassMap<OrdemServico>

    {
        public OrderServicoMap()
        {

            Table("tblOrdemServicos");
            Id(os => os.id).GeneratedBy.Identity();
            Map(os => os.dataInicio);
            Map(os => os.dataFim);
            Map(os => os.datapagamentoAPrazo);
            Map(os => os.desconto);
            Map(os => os.situacao);
            Map(os => os.pagamentoAPrazo)
                .Nullable()
                .Length(240);
            Map(os => os.defeitoConstatado)
                .Nullable()
                .Length(240);
            Map(os => os.defeitoRelatado)
                .Nullable()
                .Length(240);
            Map(os => os.servicosRealizados)
                .Nullable()
                .Length(240);
            Map(os => os.observacoes)
                .Nullable()
                .Length(240);
            References(os => os.cliente)
                .Not
                .LazyLoad()
                .Cascade
                .SaveUpdate();
            
            References(os => os.funcionario)
                .Nullable()
                .Not
                .LazyLoad()
                .Cascade
                .SaveUpdate();

            HasManyToMany(os => os.produtos)
                .Table("tblProdutoOrdemServico")
                .ParentKeyColumn("osId")
                .ChildKeyColumn("osprodutoid")
                .Not
                .LazyLoad()
                .Cascade
                .All();

         
        }
    }
}
