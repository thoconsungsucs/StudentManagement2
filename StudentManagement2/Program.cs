using Microsoft.Extensions.DependencyInjection;
using NHibernate;
using StudentManagement2.Interface.IRepository;
using StudentManagement2.Interface.IService;
using StudentManagement2.Service;
using StudentManagement2.SqlRepository;

namespace StudentManagement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddScoped<IClassService, ClassService>();
            services.AddScoped<IStudentService, StudentService>();

            services.AddScoped<IClassRepository, ClassRepository>();
            /*services.AddSingleton<IStudentRepository, StudentRepository>();*/

            services.AddScoped<IStudentRepository, StudentRepository>();

            services.AddSingleton<App>();
            services.AddSingleton(provider => NHibernateHelper.CreateSessionFactory());

            services.AddScoped(provider =>
            {
                var sessionFactory = provider.GetService<ISessionFactory>();
                return sessionFactory.OpenSession();
            });
            var serviceProvider = services.BuildServiceProvider();
            var app = serviceProvider.GetService<App>();
            app.Run();
        }
    }
}
