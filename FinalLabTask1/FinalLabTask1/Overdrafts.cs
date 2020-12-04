using System;
using System.Collections.Generic;
using System.Text;

namespace FinalLabTask1
{
    class Overdrafts : Account
    {
        private double overdraftLimit;

        public double OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }
        public Overdrafts() { }

        public Overdrafts(string accName, string accNo, double balance, double overdraftLimit) : base(accName, accNo, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public override void Withdraw(double amount)
        {

            if (amount <= Balance + overdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine("Withdraw successful from overdraft account.");
            }
            else
                Console.WriteLine("Overdrafts amount's Limit crossed");

        }

    }
}
