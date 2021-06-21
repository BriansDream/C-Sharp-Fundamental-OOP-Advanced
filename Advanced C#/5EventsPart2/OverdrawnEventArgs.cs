using System;
namespace _5EventsPart2
{
    public class OverdrawnEventArgs : EventArgs
    {
        public decimal CurrentBalance, DebitAmount;

        public OverdrawnEventArgs(decimal CurrentBalance, decimal DebitAmount)
        {
            CurrentBalance = CurrentBalance;
            DebitAmount = DebitAmount;
        }
    }
}