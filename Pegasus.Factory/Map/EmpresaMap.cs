using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
   public  class EmpresaMap : ClassMap<Empresa>
    {
        public EmpresaMap()
        {
            Table("tblEmpresa");
            Id(empresa => empresa.id).GeneratedBy.Identity();
            Map(empresa => empresa.numero);
            Map(empresa => empresa.bairro);
            Map(empresa => empresa.CEP);
            Map(empresa => empresa.CNPJ);
            Map(empresa => empresa.complemento);
            Map(empresa => empresa.CRT);
            Map(empresa => empresa.endereco);
            Map(empresa => empresa.IE);
            Map(empresa => empresa.senha)
                    .Nullable();
           Map(empresa => empresa.serialNumberCert)
                 .Nullable();
            Map(empresa => empresa.tipoCertificado).Nullable();
            Map(empresa => empresa.path)
                .Nullable();  
            Map(empresa => empresa.logo)
                .Nullable();
            Map(empresa => empresa.logoDanfe)
                .Nullable();
            Map(empresa => empresa.nomeFantasia);
            Map(empresa => empresa.razaoSocial);
            Map(empresa => empresa.telefone);
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


        }
    }
}
