using System;
using System.Collections.Generic;
using System.Text;

namespace FinalLabTask1
{
    class SpecialSavings : Account
    {

        private int transactionNo;

        public int TransactionNo
        {
            get { return transactionNo; }
            set { transactionNo = value; }
        }

        private int transactionCount;

        public int TranssactionCount
        {
            get { return transactionCount; }
            set { transactionCount = value; }
        }

        private double openingBalance;

        public double OpeningBalance
        {
            get { return openingBalance; }
            set { openingBalance = value; }
        }

        private int depositeCount;

        public int DepositeCount
        {
            get { return depositeCount; }
            set { depositeCount = value; }
        }


        public SpecialSavings()
        {

        }

        public SpecialSavings(string accName, string accNo, double balance, int transactionNo) : base(accName, accNo, balance)
        {
            this.transactionNo = transactionNo;
            DepositeCount++;
            if (depositeCount == 1)
            {
                OpeningBalance = balance;

            }
            OpeningBalance = balance;
        }

        public override void Withdraw(double amount)
        {
            transactionCount++;
            if ((transactionCount <= transactionNo) && (Balance - amount >= (OpeningBalance / 5)))
            {
                Balance -= amount;
                Console.WriteLine("Withdraw done from special savings account");
            }
            else
            {
                if (transactionCount > transactionNo)
                {
                    Console.WriteLine("Monthly minimal number of transaction reached.");
                }

                else
                    Console.WriteLine("Special Savings Insufficient Balance");
            }

        }
    }
}
