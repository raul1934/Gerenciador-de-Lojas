using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
   public class EstadoMap : ClassMap<Estado>
    {
        public EstadoMap()
        {
            Table("tblEstado");
            Id(estado => estado.Id).GeneratedBy.Identity();
            Map(estado => estado.nome);
            // .Length(75);
            Map(estado => estado.sl);
            // .Length(3);
            Map(estado => estado.uf);
            // .Length(2);
            Map(estado => estado.ibge);
            // .Length(2);
            Map(estado => estado.ddd);
            // .Length(50);
        }
    }
}
