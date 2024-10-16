using FluentNHibernate.Mapping;
using StudentManagement2.Model;

namespace StudentManagement2.Mappings
{
    public class TeacherMap : ClassMap<Teacher>
    {
        public TeacherMap()
        {
            Table("Teacher");
            Id(x => x.Id, "TeacherId");
            Map(x => x.Name, "TeacherName");
            Map(x => x.Dob, "Dob");
        }
    }
}
