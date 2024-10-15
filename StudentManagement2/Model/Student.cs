namespace StudentManagement2.Model
{
    public class Student : Person
    {
        public required string Address { get; set; }
        public Class? Class { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Class: " + Class?.ClassName);
        }
    }
}
