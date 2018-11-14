using NHibernate;
using NHibernate.Linq;
using Pegasus.Business.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Business.Implementation
{
    public class DefaultImplementation<T> : ICrudDao<T> where T : class
    {

       
        public void Inserir(T entidade)
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
                        _session.Save(entidade);
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

        public void Atualizar(T entidade)
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                    try
                    {


                        _session.Update(entidade);
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

        public void Deletar(T entidade)
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                    try
                    {
                        _session.Delete(entidade);
                        _transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!_transaction.WasCommitted)
                            _transaction.Rollback();
                        throw new Exception("Erro ao Deletar: " + ex.Message);
                    }
                    finally
                    {
                        _session.Close();
                    }
                }
            }
        }

        public T BuscarId(int id)
        {
            
            using (ISession _session = nHibernateConection.OpenSession())
            {
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                     var T = _session.Get<T>(id);
                    _transaction.Commit();
                    return T;
                }
            }
        }

        public IList<T> Buscar()
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                return (from rs in _session.Query<T>() select rs).ToList(); 
            }

        }

        
    }
}
