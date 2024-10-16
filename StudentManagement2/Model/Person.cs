namespace StudentManagement2.Model
{
    public class Person
    {
        public virtual int Id { get; }
        public virtual required string Name { get; set; }
        public virtual required DateTime Dob { get; set; }

        public Person()
        {
        }

        public virtual void Show()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Dob: " + Dob.ToShortDateString());
        }
    }
}
