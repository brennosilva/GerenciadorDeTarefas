using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using GerenciadorDeTarefas.Infraestrutura.Mapeamento;
using Microsoft.Extensions.Configuration;
using NHibernate;

namespace GerenciadorDeTarefas.Infraestrutura.NHibernate
{
    public class NhibernateHelper
    {
        public static ISession OpenSession(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("TAREFA");
            var banco = configuration.GetSection("BANCO").Get<string>();

            if (banco == "ORACLE")
            {
                ISessionFactory sessionFactory = Fluently.Configure()
                .Database(OracleManagedDataClientConfiguration.Oracle10.ConnectionString(connectionString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TarefaMap>())
                .BuildSessionFactory();
                return sessionFactory.OpenSession();
            }
            else
            {
                ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TarefaMap>())
                .BuildSessionFactory();
                return sessionFactory.OpenSession();
            }
        }

    }
}