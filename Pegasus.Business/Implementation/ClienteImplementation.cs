using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Pegasus.Business.Repository;
using Pegasus.Factory.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Business.Implementation
{
    public class ClienteImplementation : DefaultImplementation<Cliente>
    {
        public IList<Cliente> BuscarbyNome()
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                return (from rs in _session.Query<Cliente>().OrderBy(rs => rs.nome) select rs).ToList();
            }
        }

        public IList<Cliente> BuscaPersonalizada(Nullable<DateTime> de = null, Nullable<DateTime> ate = null, string nome = null, string cpfcnjp = null, string rgie = null, Cidade cidade = null, Estado estado = null, Nullable<bool> pessoaJuridica = null)
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                var query = _session.Query<Cliente>();
                
                if(pessoaJuridica != null)
                {
                    query = query.Where(rs => rs.pessoaJuridica == pessoaJuridica);
                }
                if(!string.IsNullOrWhiteSpace(nome))
                {
                    query = query.Where(rs => rs.nome.Contains(nome));
                }
                if(de !=null && ate!=null)
                {
                    query = query.Where(rs => rs.dataCadastro <= ate && rs.dataCadastro >= de);
                }

                if(estado!= null)
                {
                    query = query.Where(rs => rs.estado ==estado);
                }

                if(cidade != null)
                {
                    query = query.Where(rs => rs.cidade == cidade);
                }

                if(!string.IsNullOrEmpty(cpfcnjp))
                {
                    query = query.Where(rs => rs.cpfCnpj.Equals(cpfcnjp));
                }

                if(!string.IsNullOrEmpty(rgie))
                {
                    query = query.Where(rs => rs.rgIe.Equals(rgie));
                }

                return query.ToList();
            }

        }
    }
}
    
