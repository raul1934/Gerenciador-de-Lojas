using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
    public class FornecedorMap : ClassMap<Fornecedor>
    {
        public FornecedorMap()
        {
            Table("tblFornecedor");
            Id(u => u.id).GeneratedBy.Identity();
            Map(u => u.numero);
            Map(u => u.cep);
            Map(u => u.nomeFantasia);
            Map(u => u.endereco);
            Map(u => u.email);
            Map(u => u.Cnpj);
            Map(u => u.Ie);
            Map(u => u.razaoSocial);
            Map(u => u.ativo);
            Map(u => u.bairro);
            Map(u => u.dataCadastro);
            HasMany(u => u.telefone)
                .Not
                .LazyLoad()
                .Cascade
                .SaveUpdate();
            HasMany(u => u.produtos)
                .Not
                .LazyLoad()
                .Cascade
                .None();
            References(u=> u.cidade)
               .Not
               .LazyLoad()
               .Cascade
               .None();
            References(u => u.estado)
              .Not
              .LazyLoad()
              .Cascade
              .None();
            References(u => u.pais)
               .Not
               .LazyLoad()
               .Cascade
               .None();
        }

    }
}
