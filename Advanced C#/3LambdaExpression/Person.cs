namespace _3LambdaExpression
{
    public class Person
    {
        public string Name
        {
            get; set;
        }

        public int Age { get; set; }

        // Constructor 
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}