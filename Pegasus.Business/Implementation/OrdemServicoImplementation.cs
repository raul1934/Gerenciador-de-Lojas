using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Pegasus.Business.Repository;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Business.Implementation
{
    public class OrdemServicoImplementation : DefaultImplementation<OrdemServico>
    {
        public IList<OrdemServico> getDatas(DateTime i, DateTime f)
        {

            using (ISession _session = nHibernateConection.OpenSession())
            {
                // DateTime dtIncio = DateTime.ParseExact(i, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // dtIncio =   dtIncio.AddDays(1);

                //   DateTime dtFim = DateTime.ParseExact(f, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                //   dtFim = dtFim.AddDays(1);

                // MessageBox.Show(dtIncio.ToString("yyyy/MM/dd"));
                return (from rs in _session.Query<OrdemServico>().Where(rs => rs.dataInicio >= i && rs.dataInicio <= f) select rs).ToList();



            }

        }

        public int getLastId()
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                int ret = -1;
                try
                {
                    ret = _session.Query<OrdemServico>().Last().id;
                }
                catch
                {
                    ret = -1;
                }

                return ret+1;


            }
        }

        public new void Atualizar(OrdemServico os)
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                    try
                    {
                        _session.Clear();
                        _session.Merge(os);
                        _transaction.Commit();
                    }

                    catch (Exception ex)
                    {
                        if (!_transaction.WasCommitted)
                            _transaction.Rollback();
                        throw new Exception("Erro ao atualizar: " + ex.Message);
                    }
                }
            }
        }

        public new void Deletar(OrdemServico os)
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                    try
                    {
                        _session.Clear();
                        _session.Delete(os);
                        _transaction.Commit();
                    }

                    catch (Exception ex)
                    {
                        if (!_transaction.WasCommitted)
                            _transaction.Rollback();
                        throw new Exception("Erro ao atualizar: " + ex.Message);
                    }
                }
            }
        }

        public new void Inserir(OrdemServico ordemServico)
        {
            //abrir uma sessao
            using (ISession _session = nHibernateConection.OpenSession())
            {
                //abrir a transacao
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                    try
                    {
                        _session.Clear();
                        //salvar em sessao
                        _session.Merge(ordemServico);
                        //_session.Save(ordemServico);
                        //banco
                        _transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        if (!_transaction.WasCommitted)
                            _transaction.Rollback();

                        throw new Exception("Erro ao salvar: " + ex.Message);
                    }
                    finally
                    {
                        _session.Close();
                        _transaction.Dispose();
                    }
                }
            }
        }

        public IList<OrdemServico> BuscaPersonalizada(Nullable<DateTime> de = null, Nullable<DateTime> ate = null, Nullable<int> numero = null, Nullable<int> situacao = null,Cliente c=null)
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                var query = _session.Query<OrdemServico>();

                if (de != null && ate != null)
                {
                    query = query.Where(rs => rs.dataInicio <= ate && rs.dataInicio >= de);
                }
                if (numero != null && numero!=0)
                {
                    query = query.Where(rs => rs.id == numero);
                }
                if (situacao != null)
                {
                    query = query.Where(rs => rs.situacao == situacao);
                }
                if(c!=null)
                {
                    query = query.Where(rs => rs.cliente.id == c.id);
                    query = query.Where(rs => rs.cliente.pessoaJuridica == c.pessoaJuridica);
                    
                }



                return query.ToList();
            }


        }
    }
}
