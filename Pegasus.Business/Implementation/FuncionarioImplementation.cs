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
   public  class FuncionarioImplementation : DefaultImplementation<Funcionario>
    {
        public Funcionario logar(string cpf,string password)
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                using(ITransaction _transacition = _session.BeginTransaction())
                try
                {
                        
                    var r = (from funcionario in _session.Query<Funcionario>().Where(funcionario => funcionario.cpf == cpf && funcionario.senha == password) select funcionario).First();
                    return r;
                }
                catch(Exception e)
                {
                    return null;
                }

               
            }
        }

        public IList<Funcionario> BuscarbyNome()
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                return (from rs in _session.Query<Funcionario>().OrderBy(rs => rs.nome) select rs).ToList();
            }
        }

        public IList<Funcionario> BuscaPersonalizada(Nullable<DateTime> de = null, Nullable<DateTime> ate = null, string nome = null, string cpfcnjp = null, string rgie = null, Cidade cidade = null, Estado estado = null)
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                var query = _session.Query<Funcionario>();

               
                if (!string.IsNullOrWhiteSpace(nome))
                {
                    query = query.Where(rs => rs.nome.Contains(nome));
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
                    query = query.Where(rs => rs.cpf.Equals(cpfcnjp));
                }

                if (!string.IsNullOrEmpty(rgie))
                {
                    query = query.Where(rs => rs.rg.Equals(rgie));
                }

                return query.ToList();
            }

        }
    }
}
