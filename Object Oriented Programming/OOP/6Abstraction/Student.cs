using System;

namespace _6Abstraction
{
    // Student class is Inheritance Person Class
    public class Student : Person, IAttendance
    {

        // Abstract method



        public Student()
        : base()
        {

        }
        // Inheritance Constructor Person Class
        public Student(string firstName, int age)
        : base(firstName, age)
        {

        }

        public void ClockIn(int hour)
        {
            // Jika datang diatas Jam 7, maka dia terlambat
            if (hour > 7)
            {
                Console.WriteLine("You come late");

            }
            else
            {
                Console.WriteLine("You come on time");
            }
        }

        public void ClockOut(int hour)
        {
            if (hour < 13)
            {
                Console.WriteLine("You go home early");
            }
            else
            {
                Console.WriteLine("You go home ontime");
            }
        }


        // Mengimplementasikan abstract method dari class Person
        // Silahkan ubah isinya, karena isinya disini hanya melempar error
        public override void methodSignature()
        {
            throw new NotImplementedException();
        }
    }
}