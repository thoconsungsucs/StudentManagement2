namespace StudentManagement2.Model
{
    public class Class
    {
        public virtual int ClassId { get; }
        public virtual required string ClassName { get; set; }
        public virtual required string Subject { get; set; }
        public virtual Teacher? Teacher { get; set; }

        public Class()
        {
        }

        public virtual void Show()
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
