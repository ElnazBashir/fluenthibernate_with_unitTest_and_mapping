using System;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using shakiba.Entities;

namespace shakiba
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var connectionString =@" Data Source=m-mohammadian;Initial Catalog=Test_DB;Persist Security Info=True;User ID=sa;Password=s@123456";
                    //var connectionStringSettings =
                    //    System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"];
                    //if (connectionStringSettings != null)
                    //{
                    //    connectionString = connectionStringSettings.ConnectionString;
                    //}

                    var cfgi = new StoreConfiguration(); 

                    var fluentConfiguration = Fluently.Configure()
                        .Database(MsSqlConfiguration.MsSql2012
                            .ConnectionString(connectionString)
                            .ShowSql()
                        );

                    var configuration =
                        fluentConfiguration.Mappings(m =>
                            m.AutoMappings.Add(AutoMap.AssemblyOf<Employee>(cfgi)
                                .UseOverridesFromAssemblyOf<Employeemap>));
                    var buildSessionFactory = configuration.ExposeConfiguration(cfg =>
                        {
                            new SchemaUpdate(cfg).Execute(false, true);
                           new SchemaExport(cfg)
.Create(false, false);
                        })
                        .BuildSessionFactory();



                    _sessionFactory = buildSessionFactory;
                }

                return _sessionFactory;
            }


        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

      
    }
}