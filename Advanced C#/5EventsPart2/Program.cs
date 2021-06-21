using System;

namespace _5EventsPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void OverdrawnHandler(object sender, OverdrawnEventArgs args)
        {
            Console.WriteLine("The account is Overdrawn!");
            Console.WriteLine($"Your current Balance: {args.CurrentBalance} ")
            Console.WriteLine($"Your debit amount : {args.DebitAmount}")
        }

    }
}
