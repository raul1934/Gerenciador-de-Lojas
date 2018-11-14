using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
   public class MarcaMap : ClassMap<Marca>
    {
        public MarcaMap()
        {
            Table("tblprodutomarca");
            Id(marca => marca.id).GeneratedBy.Identity();
            Map(marca => marca.nome).Nullable() ;
        }
    }
}
