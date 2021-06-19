using System;

namespace _5Inheritance
{
    // Turunan dari class Person
    public class Student : Person
    {

        public Student()
        // Default constructor class student memanggil default constructor class person
        : base()
        {

        }
        public Student(string name, int age)
            : base(name, age)
        {

        }

        public string getFullname()
        {
            return $"{base.fullName}";
        }

        // Override virtual method introduce
        public override string Introduce()
        {
            return $"Hi, I'm a Student, and my name is {base.fullName}";
        }

        // Override Implementasi dari property age
        public override int AGE
        {
            get
            {
                return base.age;
            }

            set
            {
                if (value < 6 && value > 17)
                    base.age = value;
                else

                    throw new ArgumentOutOfRangeException("", "Age must be between 6 and 17!");
            }

        }
    }
}