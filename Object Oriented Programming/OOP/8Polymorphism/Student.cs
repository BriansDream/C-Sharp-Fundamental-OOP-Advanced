namespace _8Polymorphism
{
    public class Student : Person
    {
        public Student()
            : base()
        {

        }
        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {

        }

        public string getFullname()
        {
            return $"{base.fullName}";
        }
    }
}