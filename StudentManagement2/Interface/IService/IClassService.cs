using StudentManagement2.Model;

namespace StudentManagement2.Interface.IService
{
    public interface IClassService
    {
        public List<Class> GetAllClasses();
        public Class? GetClassById(int classId);
    }
}
