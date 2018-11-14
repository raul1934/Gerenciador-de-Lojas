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
    public class CategoriaImplementation : DefaultImplementation<Categoria>
    {
        public IList<Categoria> BuscarbyCategoria()
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                return (from rs in _session.Query<Categoria>().OrderBy(rs => rs.categoria) select rs).ToList();
            }
        }
    }
}
