using System;
using System.Collections.Generic;
using System.Text;

namespace FinalLabTask1
{
    class SavingsAccount : Account
    {
        private int transactionNo;

        public int TransactionNo
        {
            get { return transactionNo; }
            set { transactionNo = value; }
        }

        private int transactionCount;

        public int TransactionCount
        {
            get { return transactionCount; }
            set { transactionCount = value; }
        }


        public SavingsAccount()
        {

        }

        public SavingsAccount(string accName, string accNo, double balance, int transactionNo) : base(accName, accNo, balance)
        {
            this.transactionNo = transactionNo;
        }

        public override void Withdraw(double amount)
        {
            transactionCount++;
            if (transactionCount <= transactionNo && Balance - amount >= 500)
            {
                Balance -= amount;
                Console.WriteLine("Withdraw done from savings account.");
            }
            else
            {
                if (transactionCount > transactionNo)
                {
                    Console.WriteLine("Monthly minimal number of transaction reached");
                }

                else
                    Console.WriteLine("Savings Account Insufficient Balance ");
            }

        }
    }
}
