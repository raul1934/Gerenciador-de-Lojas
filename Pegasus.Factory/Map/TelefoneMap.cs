using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
   public class TelefoneMap : ClassMap<Telefone>
    {
        public TelefoneMap()
        {
            Table("tblTelefone");
            Id(u => u.id).GeneratedBy.Identity();
            Map(u => u.telefone).Not.Nullable();
            Map(u => u.tipo).Not.Nullable();
            Map(u => u.observacao).Nullable();

        }
        }
}
