namespace StudentManagement2.Model
{
    public class Class
    {
        private static int LastId = 1;
        public int ClassId { get; }
        public required string ClassName { get; set; }
        public required string Subject { get; set; }
        public Teacher? Teacher { get; set; }

        public Class()
        {
            ClassId = LastId++;
        }

        public void Show()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("ClassId: " + ClassId);
            Console.WriteLine("ClassName: " + ClassName);
            Console.WriteLine("Subject: " + Subject);
            Teacher?.Show();
            Console.WriteLine("-----------------");
        }
    }
}
