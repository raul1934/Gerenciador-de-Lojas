using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
    public class CidadeMap : ClassMap<Cidade>
    {

        public CidadeMap()
        {
            Table("tblCidade");
            Id(cidade => cidade.Id).GeneratedBy.Identity();
            Map(cidade => cidade.ibge);
            //.Length(7);
            Map(cidade => cidade.nome);
            //.Length(120);
            Map(cidade => cidade.uf);
                //.Length(2);
        }
    }
}
