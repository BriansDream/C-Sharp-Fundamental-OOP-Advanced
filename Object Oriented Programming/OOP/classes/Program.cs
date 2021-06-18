using System;

namespace classes
{
    // Class Person
    public class Person
    {
        // Field Person
        private string firstName;
        private string lastName;
        // Method 
        public void sayHi()
        {
            Console.WriteLine("Hai {0} {1}", firstName, lastName);
        }

        // Method menerima input dengan tipe Class
        // Method overloading, > 1 method dengan nama yg sama namun inputnya untuk masing - masing method berbeda tipe data.
        public void sayHi(Person person)
        {
            Console.WriteLine("Hi, {0}", person.firstName);
        }

        // Constructor
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Person person1 = new Person();
            // person1.firstName = "Andesta";
            // person1.lastName = "Nainggolan";
            // person1.sayHi();

            // Person person2 = new Person();
            // person2.firstName = "Budi";
            // person2.sayHi();

            // Constructor
            Person person1 = new Person("Andesta", "Nainggolan");
            person1.sayHi();



        }
    }
}
