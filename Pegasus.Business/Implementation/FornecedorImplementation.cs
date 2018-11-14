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
   public class FornecedorImplementation : DefaultImplementation<Fornecedor>
    {
        public IList<Fornecedor> BuscaPersonalizada(Nullable<DateTime> de = null, Nullable<DateTime> ate = null, string nomeFantasia = null, string cpfcnjp = null, string rgie = null, Cidade cidade = null, Estado estado = null)
        {



            using (ISession _session = nHibernateConection.OpenSession())
            {
                var query = _session.Query<Fornecedor>();

               
                if (!string.IsNullOrWhiteSpace(nomeFantasia))
                {
                    query = query.Where(rs => rs.nomeFantasia.Contains(nomeFantasia));
                }
                if (de != null && ate != null)
                {
                    query = query.Where(rs => rs.dataCadastro <= ate && rs.dataCadastro >= de);
                }

                if (estado != null)
                {
                    query = query.Where(rs => rs.estado == estado);
                }

                if (cidade != null)
                {
                    query = query.Where(rs => rs.cidade == cidade);
                }

                if (!string.IsNullOrEmpty(cpfcnjp))
                {
                    query = query.Where(rs => rs.Cnpj.Equals(cpfcnjp));
                }

                if (!string.IsNullOrEmpty(rgie))
                {
                    query = query.Where(rs => rs.Ie.Equals(rgie));
                }

                return query.ToList();
            }

        }
    }
}
