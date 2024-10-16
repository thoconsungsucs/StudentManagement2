using NHibernate;
using StudentManagement2.Interface.IRepository;
using StudentManagement2.Model;

namespace StudentManagement2.SqlRepository
{
    public class ClassRepository : IClassRepository
    {
        private readonly ISession _session;

        public ClassRepository(ISession session)
        {
            _session = session;
        }

        public List<Class> GetAllClasses()
        {
            return _session.Query<Class>().ToList();
        }

        public Class? GetClassById(int classId)
        {
            return _session.Get<Class>(classId);
        }
    }
}
