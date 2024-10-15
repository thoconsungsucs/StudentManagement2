using StudentManagement2.Model;

namespace StudentManagement2.Interface.IService
{
    public interface IStudentService
    {
        public Student? GetStudentById(int studentId);
        public List<Student> GetAllStudents();
        public void AddStudent(Student student);
        public void UpdateStudent(Student student);
        public void DeleteStudent(int studentId);
    }
}
