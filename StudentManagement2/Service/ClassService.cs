using StudentManagement2.Interface.IRepository;
using StudentManagement2.Interface.IService;
using StudentManagement2.Model;

namespace StudentManagement2.Service
{
    internal class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;

        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public List<Class> GetAllClasses()
        {
            return _classRepository.GetAllClasses();
        }

        public Class? GetClassById(int classId)
        {
            return _classRepository.GetClassById(classId);
        }

    }
}
