using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Pegasus.Factory.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Business.Repository
{
    public class nHibernateConection
    {
        private static ISessionFactory session;

        private static ISessionFactory CriarSessao()
        {
            if (session != null)
                return session;
            //configurar a conexao
            /*  FluentConfiguration _configuration = Fluently.Configure()
                                                           .Database(
                                                               MySQLConfiguration.Standard.ConnectionString(x => x.Server
                                                                                                                     ("localhost")
                                                                                                                  .Username
                                                                                                                     ("Raul")
                                                                                                                  .Password
                                                                                                                     ("1234")
                                                                                                                  .Database
                                                                                                                     ("db_pegasus")))
                                                           .Mappings(
                                                               c => c.FluentMappings.AddFromAssemblyOf<ClienteMap>())

                                                    .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true)); */
        /*
        FluentConfiguration _configuration = Fluently.Configure().
        Database(MySQLConfiguration.Standard.ConnectionString(x => x.Server
                                                                                                                     ("localhost")
                                                                                                                  .Username
                                                                                                                     ("root")
                                                                                                                  .Password
                                                                                                                     ("123456")
                                                                                                                  .Database
                                                                                                                     ("db_pegasus1"))).
        Mappings(m => m.FluentMappings.AddFromAssemblyOf<ClienteMap>()).
        ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, false));
        */

        FluentConfiguration _configuration = Fluently.Configure().
        Database(SQLiteConfiguration.Standard.UsingFileWithPassword("db.db", "1234")).
        Mappings(m => m.FluentMappings.AddFromAssemblyOf<ClienteMap>()).
        ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true));


            session = _configuration.BuildSessionFactory();
            return session;

        }

        public static ISession OpenSession()
        {
            return CriarSessao().OpenSession();

        }
    }
}
