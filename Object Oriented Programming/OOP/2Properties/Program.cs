using System;

namespace _2Properties
{

    public class Person
    {
        private string firstName = "Andika";
        private string lastName = "Nainggolan";

        private int age;

        // Mengakses private field dari class
        // PROPERTY
        public string FIRSTNAME
        {
            // Akses modifier private 
            // membuat nilai dari field class tak dapat diakses
            // private get
            // {
            //     return firstName;
            // }

            // Membuat menjadi read-only dengan akses modifier / tidak dapat di assign
            // private set
            set
            {
                firstName = value;
            }
        }
        // PROPERTY
        public string LASTNAME
        {
            get
            {
                return lastName;
            }
            // set
            // {

            // }
        }

        // Property
        public int AGE
        {
            get
            {
                return age;
            }

            set
            {
                if (value >= 12)
                    age = value;
                else
                    Console.WriteLine("Tidak boleh < 12");

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            // Nilai tidak dapat diubah karena status read-only (aksesor set dihapus)
            // person1.LASTNAME = "Dina";

            // Nilai dari field tidak dapat diakses karena aksesor GET dihapus
            // Console.WriteLine(person1.LASTNAME);
            // ========================================================================

            // Tidak dapat di assign dengan nilai baru karena aksesor set private
            // person1.FIRSTNAME = "Dinan";
            // tidak dapat mengakses nilai field karena aksesor get bertipe private
            // Console.WriteLine(person1.FIRSTNAME);


            person1.AGE = 11;
            Console.WriteLine(person1.AGE);
        }
    }
}
