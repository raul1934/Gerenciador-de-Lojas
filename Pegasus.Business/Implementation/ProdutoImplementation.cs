using NHibernate;
using NHibernate.Linq;
using Pegasus.Business.Repository;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Business.Implementation
{
    public class ProdutoImplementation : DefaultImplementation<Produto>
    {

        public IList<Produto> BuscarbyDescricaoInativo()
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                return (from rs in _session.Query<Produto>().OrderBy(rs=>rs.descricao) select rs).ToList();
            }
        }

        public IList<Produto> BuscarbyDescricaoAtivo()
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                return (from rs in _session.Query<Produto>().Where(rs=>rs.ativo).OrderBy(rs => rs.descricao) select rs).ToList();
            }
        }

        

        public Produto BuscarCobBarras(string codBarras)
        {
   
            using (ISession _session = nHibernateConection.OpenSession())
            {
                return (from rs in _session.Query<Produto>().Where(rs=>rs.codigoBarras == codBarras) select rs).FirstOrDefault();
            }
        }

        public IList<Produto> BuscaPersonalizada(Nullable<DateTime> de=null,Nullable<DateTime> ate=null,string descricao=null,string codbarras =null,
                                                Marca marca =null,Fornecedor fornecedor =null,Categoria categoria=null,SubCategoria subcategoria=null)
        {
            using (ISession _session = nHibernateConection.OpenSession())
            {
                var query = _session.Query<Produto>();

                if(de!=null && ate!=null)
                {
                    query = query.Where(rs => rs.dataInicio <= ate && rs.dataFim >= de);
                }

                if(!string.IsNullOrEmpty(descricao))
                {
                    query = query.Where(rs => rs.descricao.Contains(descricao));
                }

                if(!string.IsNullOrEmpty(codbarras))
                {
                    query = query.Where(rs => rs.codigoBarras == codbarras);
                }

                if(marca !=null)
                {
                    query = query.Where(rs => rs.marca == marca);
                }
                if(fornecedor!=null)
                {
                    query = query.Where(rs => rs.fornecedor == fornecedor);
                }
                if(categoria!=null)
                {
                    query = query.Where(rs => rs.categoria == categoria);
                }

                if(subcategoria!=null)
                {
                    query = query.Where(rs => rs.subcategoria == subcategoria);
                }

                return query.ToList();
            }
        }

        public new void Inserir(Produto produto)
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
                        _session.Save(produto);
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


        public new void Deletar(Produto produto)
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
                        _session.Delete(produto);
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
    }
}
