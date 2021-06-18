using System;

namespace Fundamental
{


    // Enum adalah tipe data
    public enum SeatType
    {
        FirstClass = 1,
        Business,
        Economy,
    }

    // Struct (Data Type)
    public struct Person
    {
        // Field
        public string FirstName;
        public string LastName;

        // Method 
        public void GetFullName()
        {
            Console.Write(" My name is {0} {1}", FirstName, LastName);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Struct
            Person me = new Person();
            me.FirstName = "Andesta";
            me.LastName = "Nainggolan";
            me.GetFullName();
        }
    }
}