namespace StudentManagement2.Model
{
    public class Student : Person
    {
        public virtual required string Address { get; set; }
        public virtual Class? Class { get; set; }

        public virtual new void Show()
        {
            base.Show();
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Class: " + Class?.ClassName);
        }
    }
}
