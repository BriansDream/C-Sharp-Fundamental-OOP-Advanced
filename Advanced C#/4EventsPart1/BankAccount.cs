using System;
namespace _4EventsPart1
{
    public class BankAccount
    {
        // Delegate
        // public delegate void OverdrawnEventHandler(); // diganti dengan Built In Delegate Action

        // Built in Delegate Action
        public event Action Overdrawn;



        // Event (nama Eventnya Overdrawn)
        public event OverdrawnEventHandler Overdrawn;
        public decimal Balance { get; set; }

        public void Credit(decimal amount)
        {
            Balance += amount;
        }
        public void Debit(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else

            {
                // Saldo tak dapat dikurangi melebihi sisa saldonya
                if (Overdrawn != null)
                {
                    Overdrawn();
                }
            }
        }
    }
}