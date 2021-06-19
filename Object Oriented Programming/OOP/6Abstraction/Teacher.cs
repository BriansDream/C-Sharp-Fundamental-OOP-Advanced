using System;
namespace _6Abstraction
{
    public class Teacher : Person, IAttendance
    {

        // Menerapkan default constructor dari class person
        public Teacher()
        : base()
        {

        }

        public void ClockIn(int hour)
        {
            // Jika datang diatas Jam 7, maka dia terlambat
            if (hour > 9)
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
            if (hour < 17)
            {
                Console.WriteLine("You go home early");
            }
            else
            {
                Console.WriteLine("You go home ontime");
            }
        }
    }
}