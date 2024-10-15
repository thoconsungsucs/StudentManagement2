using Microsoft.Extensions.DependencyInjection;
using StudentManagement2.Interface.IRepository;
using StudentManagement2.Interface.IService;
using StudentManagement2.Repository;
using StudentManagement2.Service;

namespace StudentManagement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddScoped<IClassService, ClassService>();
            services.AddScoped<IStudentService, StudentService>();

            services.AddSingleton<IClassRepository, ClassRepository>();
            services.AddSingleton<IStudentRepository, StudentRepository>();

            services.AddSingleton<App>();

            var serviceProvider = services.BuildServiceProvider();
            var app = serviceProvider.GetService<App>();
            app.Run();
        }
    }
}
