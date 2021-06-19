namespace _8Polymorphism
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int age;
        public string fullName;



        // Property
        public string FIRSTNAME
        {
            get
            {
                return firstName;
            }

        }

        public string LASTNAME
        {
            get
            {
                return lastName;
            }
        }




        // Constructor
        public Person()
        : this("GUEST", "GUEST")
        {

        }
        public Person(string firstName, string lastName)
        : this(firstName, lastName, 17)
        {

        }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.fullName = firstName + lastName;
        }

    }
}