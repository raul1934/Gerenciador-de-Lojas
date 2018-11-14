using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
   public class FuncionarioMap : ClassMap<Funcionario>
    {
        public FuncionarioMap()
        {
            Table("tblFuncionario");
            Id(funcionario => funcionario.id).GeneratedBy.Identity();
            Map(funcionario => funcionario.numero).Not.Nullable();
            Map(funcionario => funcionario.senha).Not.Nullable();
            Map(funcionario => funcionario.cep).Not.Nullable();
            Map(funcionario => funcionario.nome).Not.Nullable();
            Map(funcionario => funcionario.endereco).Not.Nullable();
            Map(funcionario => funcionario.email).Not.Nullable();
            Map(funcionario => funcionario.cpf).Not.Nullable();
            Map(funcionario => funcionario.rg).Not.Nullable();
            Map(funcionario => funcionario.ativo).Not.Nullable();
            Map(funcionario => funcionario.bairro).Not.Nullable();
            Map(funcionario => funcionario.admissao).Not.Nullable();
            Map(funcionario => funcionario.nascimento).Not.Nullable();
            Map(funcionario => funcionario.dataCadastro).Not.Nullable();
            References(funcionario => funcionario.permissoes)
                .Not
                .LazyLoad()
                .Cascade
                .SaveUpdate();
            HasMany(funcionario => funcionario.telefone)
                .Not
                .LazyLoad()
                .Cascade
                .SaveUpdate();
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

        }

    }
}
