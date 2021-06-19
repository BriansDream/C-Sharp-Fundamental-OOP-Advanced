namespace _5Inheritance
{
    public class Person
    {
        public string name;
        protected int age;
        protected string fullName;
        public string alamat;

        // Property 
        public virtual int AGE
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }


        public Person()
        : this("GUEST", 17)
        {

        }

        public Person(string name, int age)
        : this(name, age, "Guest")
        {

        }

        public Person(string name, int age, string alamat)
        {
            this.name = name;
            this.age = age;
            this.alamat = alamat;
            fullName = $"{name}  {alamat}";
        }


        // Virtual Method 
        public virtual string Introduce()
        {
            return $"Hi, I'm a Person, and my name is {fullName}";


        }



    }
}