using NHibernate;
using StudentManagement2.Interface.IRepository;
using StudentManagement2.Model;

namespace StudentManagement2.SqlRepository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ISession _session;

        public StudentRepository(ISession session)
        {
            _session = session;
        }

        public void AddStudent(Student student)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                _session.Save(student);
                transaction.Commit();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                _session.Update(student);
                transaction.Commit();
            }
        }

        public void DeleteStudent(Student student)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                _session.Delete(student);
                transaction.Commit();
            }
        }

        public List<Student> GetAllStudents()
        {
            return _session.Query<Student>().ToList();
        }

        public Student GetStudentById(int id)
        {
            return _session.Get<Student>(id);
        }
    }
}
