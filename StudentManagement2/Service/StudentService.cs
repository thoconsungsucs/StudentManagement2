using StudentManagement2.Interface.IRepository;
using StudentManagement2.Interface.IService;
using StudentManagement2.Model;

namespace StudentManagement2.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IClassRepository _classRepository;

        public StudentService(IStudentRepository studentRepository, IClassRepository classRepository)
        {
            _studentRepository = studentRepository;
            _classRepository = classRepository;
        }

        public Student? GetStudentById(int studentId)
        {
            var student = _studentRepository.GetStudentById(studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found");
            }
            return student;
        }

        public List<Student> GetAllStudents()
        {
            var students = _studentRepository.GetAllStudents();
            return students;
        }

        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            var studentInDb = _studentRepository.GetStudentById(student.Id);
            if (studentInDb == null)
            {
                Console.WriteLine("Student not found");
            }
            else
            {
                studentInDb.Name = student.Name;
                studentInDb.Address = student.Address;
                studentInDb.Class = student.Class;
                studentInDb.Dob = student.Dob;
            }
        }

        public void DeleteStudent(int studentId)
        {
            var student = _studentRepository.GetStudentById(studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found");
            }
            else
            {
                _studentRepository.DeleteStudent(student);
            }
        }

    }
}
