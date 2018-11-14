using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
   public class ProdutoPrecoMap : ClassMap<ProdutoPreco>
    {
        public ProdutoPrecoMap()
        {
            Table("tblProdutoPreco");
            Id(preco => preco.Id).GeneratedBy.Identity();
            Map(preco => preco.precodeCompra);
            Map(preco => preco.precoDeCusto);
            Map(preco => preco.precoFrete);
            Map(preco => preco.acrescimoFrete);
            Map(preco => preco.margemLucroVista).Scale(2).Precision(4);
            Map(preco => preco.margemLucroPrazo).Scale(2).Precision(4);
            Map(preco => preco.precoVendaPrazo).Scale(2).Precision(9);
            Map(preco => preco.precoVendaVista).Scale(2).Precision(9);
            Map(preco => preco.dataInicio);
            Map(preco => preco.dataFim).Nullable();
            Map(preco => preco.ativo);
        }
          
    }
}
