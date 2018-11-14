using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;

namespace Pegasus.Factory.Map
{
    public class EstoqueMap : ClassMap<ProdutoEstoque>
    {
        public EstoqueMap()
        {
            Table("tblEstoque");
            Id(estoque => estoque.Id).GeneratedBy.Identity();
            Map(estoque => estoque.dataFim).Nullable();
            Map(estoque => estoque.dataInicio);
            Map(estoque => estoque.atual);
            Map(estoque => estoque.ativo);
        }
    }
}
