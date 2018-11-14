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
    public class VendaImplementation : DefaultImplementation<Venda>
    {

        public IList<Venda> BuscarPorData(DateTime dataInicio,DateTime dataFim)
        {
           

                using (ISession _session = nHibernateConection.OpenSession())
                {
                    // DateTime dtIncio = DateTime.ParseExact(i, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    // dtIncio =   dtIncio.AddDays(1);

                    //   DateTime dtFim = DateTime.ParseExact(f, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    //   dtFim = dtFim.AddDays(1);

                    // MessageBox.Show(dtIncio.ToString("yyyy/MM/dd"));
                    return (from rs in _session.Query<Venda>().Where(rs => rs.dtFinalizacao >= dataInicio && rs.dtFinalizacao <= dataFim) select rs).ToList();



                }

            
        }
    }
}
