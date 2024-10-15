using StudentManagement2.Interface.IRepository;
using StudentManagement2.Model;

namespace StudentManagement2.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student? GetStudentById(int studentId)
        {
            return students.FirstOrDefault(s => s.Id == studentId);
        }

        public void UpdateStudent(Student student)
        {
            return;
        }
    }
}
