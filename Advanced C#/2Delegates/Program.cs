using System;

namespace _2Delegates
{
    class Program
    {

        // Delegates
        // Memanggil function
        // public delegate void CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {
            var calculation = new Calculator();
            // calculation.Addition(20, 30);

            // memanggil Delegate dengan variablenya di isi dengan nama instance objek dari callculator dan method didalam class calculator.
            // CalculateDelegate calcDelegate = calculation.Addition;

            // Delegate Action
            Action<int, int> calcDelegate = calculation.Addition;


            calcDelegate += calculation.Subtraction;
            calcDelegate += Multiplication;

            calcDelegate(20, 10);


        }


        // Function baru
        public static void Multiplication(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
    }
}
