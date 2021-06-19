using System;

namespace _4Static
{

    class Person
    {
        // Field
        public string name;
        public static int totalPerson;
        public string alamat;
        public int age;

        // readonly membuat ID tidak dapat diubah
        private readonly int id;

        // Property ID
        public int ID
        {
            get
            {
                return this.id;
            }
            // set
            // {
            //     this.id = value;
            // }

        }
        // Keyword static hanya dapat mengakses member class  static 
        public static void getTotalPerson()
        {
            Console.WriteLine("Total Person {0}", totalPerson);
        }

        // Constructor 
        public Person(string name, int age, string alamat)
        {
            this.name = name;
            this.age = age;
            this.alamat = alamat;
            // Membuat ID yang berbeda - beda untuk tiap objek person
            this.id = totalPerson++;

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            // Instance class
            Person person1 = new Person("Andesta", 29, "NurulYaqin");
            // Console.WriteLine(Person.totalPerson++);
            Person person2 = new Person("Budi", 29, "PKP");
            // Console.WriteLine(Person.totalPerson++);
            Person person3 = new Person("Bulma", 29, "PKP");
            // Console.WriteLine(Person.totalPerson++);
            Person.getTotalPerson();
            Console.WriteLine(person1.ID);

        }
    }
}
