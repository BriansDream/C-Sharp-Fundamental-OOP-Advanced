using System;
namespace _2Delegates
{
    public class Calculator
    {
        public void Addition(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtraction(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
    }
}