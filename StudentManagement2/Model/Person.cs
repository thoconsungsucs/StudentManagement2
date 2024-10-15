namespace StudentManagement2.Model
{
    public class Person
    {
        private static int LastId = 1;
        public int Id { get; }
        public required string Name { get; set; }
        public required string Dob { get; set; }

        public Person()
        {
            Id = LastId++;
        }

        public virtual void Show()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Dob: " + Dob);
        }
    }
}
