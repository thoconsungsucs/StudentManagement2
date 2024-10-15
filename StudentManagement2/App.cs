using StudentManagement2.Interface.IService;
using StudentManagement2.Model;

namespace StudentManagement2
{
    public class App
    {
        private readonly IClassService _classService;
        private readonly IStudentService _studentService;

        public App(IClassService classService, IStudentService studentService)
        {
            _classService = classService;
            _studentService = studentService;
        }

        public static void ShowMenu()
        {
            Console.WriteLine("1. Show all students");
            Console.WriteLine("2. Add student");
            Console.WriteLine("3. Change student's information");
            Console.WriteLine("4. Delete student");
            Console.WriteLine("5. Sort student list following name");
            Console.WriteLine("6. Search student by Id");
            Console.WriteLine("7. Exit");
        }

        public void Run()
        {
            while (true)
            {
                ShowMenu();
                Console.Write("Choose an option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ShowAllStudents();
                        break;
                    case "2":
                        AddStudent();
                        break;
                    case "3":
                        UpdateStudent();
                        break;
                    case "4":
                        DeleteStudent();
                        break;
                    case "5":
                        SortStudentList();
                        break;
                    case "6":
                        SearchStudentById();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        public void SearchStudentById()
        {
            var student = _studentService.GetStudentById(int.Parse(Console.ReadLine()));
            if (student != null)
            {
                student.Show();
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        public void ShowAllStudents()
        {
            var students = _studentService.GetAllStudents();
            foreach (var student in students)
            {
                student.Show();
            }
        }

        public void AddStudent()
        {
            Console.Write("Enter student's name: ");
            var name = Console.ReadLine();
            Console.Write("Enter student's dob: ");
            var dob = Console.ReadLine();
            Console.Write("Enter student's address: ");
            var address = Console.ReadLine();
            Console.Write("Enter student's classId: ");
            _classService.GetAllClasses().ForEach(c => c.Show());
            Class? c = GetClass();

            var student = new Student
            {
                Name = name,
                Dob = dob,
                Address = address,
                Class = c
            };
            _studentService.AddStudent(student);
        }

        public void ShowStudents()
        {
            var students = _studentService.GetAllStudents();
            students.ForEach(s => s.Show());
        }

        public void UpdateStudent()
        {
            Console.Write("Enter student's id: ");
            var studentId = int.Parse(Console.ReadLine());
            var student = _studentService.GetStudentById(studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            Console.Write("Enter student's name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter student's dob: ");
            student.Dob = Console.ReadLine();
            Console.Write("Enter student's address: ");
            student.Address = Console.ReadLine();
            Console.Write("Enter student's classId: ");
            _classService.GetAllClasses().ForEach(c => c.Show());
            Class? c = GetClass();

            student.Class = c;
            _studentService.UpdateStudent(student);
        }

        public void DeleteStudent()
        {
            Console.Write("Enter student's id: ");
            var studentId = int.Parse(Console.ReadLine());
            _studentService.DeleteStudent(studentId);
        }

        public void SortStudentList()
        {
            var students = _studentService.GetAllStudents().OrderBy(s => s.Name).ToList();
            students.ForEach(s => s.Show());
        }

        private Class? GetClass()
        {
            Class? c = null;
            int classId = -1;
            while (c == null)
            {
                Console.Write("Enter student's class id (0 to skip): ");
                classId = int.Parse(Console.ReadLine());

                if (classId == 0)
                {
                    break;
                }

                c = _classService.GetClassById(classId);

                if (c == null)
                {
                    Console.WriteLine("Class not found. Please try again.");
                }
            }
            return c;
        }
    }


}
