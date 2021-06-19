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
                // if (value >= 12)
                //     age = value;
                // else
                //     Console.WriteLine("Tidak boleh < 12");

                // if (value > 12)
                // {
                //     age = value;
                // }
                // else
                // {
                //     throw new ArgumentOutOfRangeException("", "Age must be greater or equal to 11");
                // }


                // Error Handling using try catch
                if (value > 12)
                {
                    age = value;
                }
                // else
                // {
                //     throw new ArgumentOutOfRangeException("", "Age must be greater or equal ");
                // }



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


            // person1.AGE = 0;
            // Console.WriteLine(person1.AGE);
            try
            {
                person1.AGE = 13;
                Console.WriteLine("AGE {0}", person1.AGE);


            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
