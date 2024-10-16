using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using StudentManagement2.Model;

public class NHibernateHelper
{
    private static ISessionFactory _sessionFactory;

    public static ISessionFactory CreateSessionFactory()
    {
        if (_sessionFactory == null)
        {
            try
            {
                _sessionFactory = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012
                        .ConnectionString(c => c
                            .Server("NGUYENDUYTHANH")
                            .Database("StudentManagement")
                            .TrustedConnection()))
                    //.ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Student>())
                    .BuildSessionFactory();
            }
            catch (FluentConfigurationException ex)
            {
                // Log exception details for debugging
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
        }
        return _sessionFactory;
    }

    public static ISession OpenSession()
    {
        return _sessionFactory.OpenSession();
    }
}
