using StudentManagement2.Model;

namespace StudentManagement2.Interface.IRepository
{
    public interface IClassRepository
    {
        public List<Class> GetAllClasses();
        public Class? GetClassById(int classId);
    }
}
