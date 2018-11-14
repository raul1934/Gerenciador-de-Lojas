using NHibernate;
using NHibernate.Linq;
using Pegasus.Business.Repository;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Business.Implementation
{
   public  class MarcaImplementation : DefaultImplementation<Marca>
    {
        public IList<Marca> BuscarbyMarca()
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                return (from rs in _session.Query<Marca>().OrderBy(rs => rs.nome) select rs).ToList();
            }
        }
    }
}
