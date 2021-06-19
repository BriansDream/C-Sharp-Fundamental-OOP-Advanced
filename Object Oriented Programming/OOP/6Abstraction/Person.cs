namespace _6Abstraction
{
    // ABstract class
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        protected int age;

        // Abstract method
        public abstract void methodSignature();


        public Person()
        : this("GUEST", 17)
        {

        }
        public Person(string firstName, int age)
        : this(firstName, "GUEST", 20)
        {

        }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

    }
}