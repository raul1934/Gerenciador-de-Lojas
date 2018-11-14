using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
    public class ProdutoMap : ClassMap<Produto>
    {
        public ProdutoMap()
        {
            Table("tblProduto");
            Id(p => p.id).GeneratedBy.Identity();
            Map(p => p.descricao);
            Map(p => p.ativo);
            Map(p => p.imagem);
            Map(p => p.altura);
            Map(p => p.comprimento);
            Map(p => p.especificacao);
            Map(p => p.prateleira);
            Map(p => p.peso);
            Map(p => p.dataFim)
                .Nullable();
            Map(p => p.dataInicio);
            Map(p => p.corredor);
            Map(p => p.naoControlarEstoque);
            Map(p => p.unidadeMedida);
            Map(p => p.codigoBarras);
            Map(p => p.codInterno);
            References(p => p.categoria)
               .Not
               .LazyLoad()
               .Cascade
               .SaveUpdate();
            References(p => p.subcategoria)
               .Not
               .LazyLoad()
               .Cascade
               .SaveUpdate();
            References(p => p.fornecedor)
               .Nullable()
               .Not
               .LazyLoad()
               .Cascade
               .SaveUpdate();
            References(p => p.marca)
                .Nullable()
                .Not
                .LazyLoad()
                .Cascade
                .All();

           
            
            HasMany(p => p.estoque)
                .Not
                .LazyLoad()
                .Cascade
                .SaveUpdate();

            HasMany(p => p.preco)
                .Not
                .LazyLoad()
                .Cascade
                .SaveUpdate();


        }

    }
}
