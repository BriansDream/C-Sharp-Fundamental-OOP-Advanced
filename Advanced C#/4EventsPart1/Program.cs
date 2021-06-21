using System;

namespace _4EventsPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            // Subscribe Event
            account.Overdrawn += OverdrawnEventHandler;
            account.Balance = 1000m;
            // account.Credit(2000);

            account.Debit(1200);

            // Cek saldo
            Console.WriteLine(account.Balance);

        }

        public static void OverdrawnEventHandler()
        {
            Console.WriteLine("The Account is Overdrawn");
        }
    }
}
