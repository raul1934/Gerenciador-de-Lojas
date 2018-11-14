using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
    public class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Table("tblCliente");
            Id(u => u.id).GeneratedBy.Identity();
            Map(u => u.numero);
            Map(u => u.cep);
            Map(u => u.nome);
            Map(u => u.endereco);
            Map(u => u.email);
            Map(u => u.cpfCnpj);
            Map(u => u.rgIe);
            Map(u => u.pessoaJuridica);
            Map(u => u.ativo);
            Map(u => u.dataCadastro);
            Map(u => u.nascimento)
                .Nullable();
            References(empresa => empresa.cidade)
                .Not
                .LazyLoad()
                .Cascade
                .SaveUpdate();
            References(empresa => empresa.estado)
              .Not
              .LazyLoad()
              .Cascade
              .SaveUpdate();
            References(empresa => empresa.pais)
               .Not
               .LazyLoad()
               .Cascade
                .SaveUpdate();
            Map(u => u.bairro);
            Map(u => u.razaoSocial);
            HasMany(u => u.telefone)
                .Not
                .LazyLoad()
                .Cascade
                .SaveUpdate();



        }
    }
}
