using StudentManagement2.Interface.IRepository;
using StudentManagement2.Model;
namespace StudentManagement2.Repository
{
    public class ClassRepository : IClassRepository

    {
        private List<Class> classes = new List<Class>();

        public ClassRepository()
        {
            var teacher1 = new Teacher
            {
                Dob = "01/01/1990",
                Name = "Teacher 1",
            };
            classes.Add(new Class
            {
                ClassName = "Class 1",
                Subject = "Math",
                Teacher = teacher1
            });

            classes.Add(new Class
            {
                ClassName = "Class 2",
                Subject = "English",
                Teacher = teacher1
            });
        }
        public List<Class> GetAllClasses()
        {
            return classes;
        }

        public Class? GetClassById(int classId)
        {
            return classes.FirstOrDefault(c => c.ClassId == classId);
        }
    }
}
