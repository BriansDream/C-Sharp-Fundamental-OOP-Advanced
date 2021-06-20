using System;

namespace _1Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            // INstance objek 
            var valueMax = new Math<double>();
            // call Method MAX
            // Console.WriteLine(valueMax.Max(10, 2));

            var result = valueMax.Max(10.3, 20.2);
            Console.WriteLine(result);

            var list = new System.Collections.Generic.List<int>();
            list.Add(45);
            list.Add(30);
            list.Add(100);

            var isContain = list.Contains(50);
            Console.WriteLine(isContain);
        }
    }
}
