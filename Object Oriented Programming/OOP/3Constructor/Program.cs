using System;

namespace _3Constructor
{

    public class Person
    {

        private string name;
        private int age;
        private string alamat;
        public void sayHi()
        {
            Console.WriteLine("Hai Nama {0} Umur {1}", this.name, this.age);
        }



        // Property untuk mengakses private field class
        public string NAME
        {
            get
            {
                return name;
            }
        }
        public int AGE
        {
            get
            {
                return age;
            }
        }

        public string ALAMAT
        {
            get
            {
                return alamat;
            }
        }




        // Constructor 1
        public Person(string name, int age)
        // Akan menjalankan constructor kedua 
        : this(name, age, "Guest")
        {
            // assign private field name and age yang merupakan member dari class person dengan nilai yang didapat dari argument constructor tersebut
            // this.name = name;
            // this.age = age;
            // this.alamat = "Guest";
        }

        // Constructor 2
        public Person(string name, int age, string alamat)
        {
            this.name = name;
            this.age = age;
            this.alamat = alamat;
        }



        // Constructor 3 
        // Constructor Default 
        public Person()
        // Menyederhanakan kode didalam blok constructor
        // Akan menjalankan constructor yg memiliki 2 parameter yaitu constructor 1
        : this("Guest", 17)
        {

            // Memberikan nilai default untuk masing - masing field
            // this.name = "Guest";
            // this.age = 17;
            //     this.alamat = "Guest";
            // }

        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            // Akses ke constructor default
            var person1 = new Person();
            Console.WriteLine(person1.ALAMAT);

            // Akses ke Constructor 2 
            var person2 = new Person("Andesta", 20, "Nurul Yaqin");
            Console.WriteLine(person2.ALAMAT);


            // Akses ke constructor 1 
            var person3 = new Person("Andika", 30);
            Console.WriteLine(person3.ALAMAT);

        }
    }
}
