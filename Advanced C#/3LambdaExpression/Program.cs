using System;
using System.Collections.Generic;
namespace _3LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delegate and Lambda
            // Func<int, int> square = x => x * x;
            // Console.WriteLine(square(10));

            // Func<int, int, int> rectangle = (x, y) => x * y;
            // Console.WriteLine(rectangle(3, 5));

            var person1 = new List<Person>();
            person1.Add(new Person("Wisnu", 17));
            person1.Add(new Person("Wajing", 27));
            person1.Add(new Person("Bulma", 57));

            // var belowTwenty = person1.FindAll(isBelowTwenty);

            // var belowTwenty = person1.FindAll(person1 => person1.Age < 20);

            // Konvension Lambda Expression
            var belowTwenty = person1.FindAll(p => p.Age < 20);

            foreach (var item in belowTwenty)
            {
                Console.WriteLine(item.Name);
            }
        }


        //Method untuk Predicate
        // public static bool isBelowTwenty(Person person)
        // {
        //     return person.Age < 20;
        // }

    }
}
