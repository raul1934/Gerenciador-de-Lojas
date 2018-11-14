using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
   public class PaisMap : ClassMap<Pais>
    {
        public PaisMap()
        {
            Table("tblPais");
            Id(pais => pais.Id).GeneratedBy.Identity();
            Map(pais => pais.nome);
            //  .Length(60);
            Map(pais => pais.nomePortugues);
            // .Length(60);
            Map(pais => pais.sigla);
            //.Length(2);
            Map(pais => pais.bacen);
             //  .Length(5);

        }
         
    }
}
