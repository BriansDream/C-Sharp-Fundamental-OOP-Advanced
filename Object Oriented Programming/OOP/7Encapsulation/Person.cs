using System;
namespace _7Encapsulation
{
    public class Person
    {

        private string firstName;
        private string lastName;
        protected int age;
        public Person()
        : this("GUEST", "GUEST")
        {

        }

        public Person(string firstName, string lastName)
        : this(firstName, lastName, 20)
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