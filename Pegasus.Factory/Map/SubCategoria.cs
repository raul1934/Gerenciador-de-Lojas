using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
    public class SubCategoriaMap : ClassMap<SubCategoria>
    {
        public SubCategoriaMap()
        {
            Table("tblprodutosubcategoria");
            Id(categoria => categoria.id).GeneratedBy.Identity();
            Map(categoria => categoria.categoria);
        }
    }
}
