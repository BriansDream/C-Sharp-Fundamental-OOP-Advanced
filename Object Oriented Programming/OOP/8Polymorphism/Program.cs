using System;

namespace _8Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            // var resultFirstName = student1.FIRSTNAME = "Andika";
            // Console.WriteLine(resultFirstName);

            // Membuat objek setelah polymorphism
            Person student2 = new Student("Budi", "Dian");
            student1.getFullname();
        }
    }
}
