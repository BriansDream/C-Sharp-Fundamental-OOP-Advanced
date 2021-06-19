using System;

namespace _5Inheritance
{


    class Program
    {
        static void Main(string[] args)
        {

            Student person1 = new Student();
            Console.WriteLine(person1.name);

            // Instance Student, yang merupakan turunan dari Person Class
            Student person2 = new Student("Andesta", 20);
            Console.WriteLine(person2.name);
            // Memanggil method getFullname() pada Person
            var Fullname = person2.getFullname();
            Console.WriteLine(Fullname);
            var introduce = person2.Introduce();

            // Console.WriteLine(person1.Introduce());
            person2.AGE = 3;
            var resultVirtualProperty = person2.AGE;
            Console.WriteLine(resultVirtualProperty);



        }
    }
}
