using System;
using System.Collections.Generic;
using System.Text;

namespace FinalLabTask1
{
    class FixedAccount : Account
    {
        private int tenureYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        private int createYear;

        public int CreateYear
        {
            get { return createYear; }
            set { createYear = value; }
        }

        public FixedAccount()
        {

        }
        public FixedAccount(string accNo, string accName, double balance, int createYear, int tenureYear) : base(accNo, accName, balance)
        {
            this.createYear = createYear;
            this.tenureYear = tenureYear;
        }
        override public void Withdraw(double amount)
        {
            string curentYear = DateTime.Now.Year.ToString();
            int cyear = Int32.Parse(curentYear);
            if ((cyear - createYear) >= tenureYear)
            {
                balance -= amount;
                Console.WriteLine("Withdraw successfull from Fixed Account");
            }
            else
            {
                if ((cyear - createYear) < tenureYear)
                    Console.WriteLine("Account is not ready for withdraw");
                else
                    Console.WriteLine("Fixed account Insufficient balance");
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Account Opening Year: " + createYear);
            Console.WriteLine("Account Tenure Year: " + tenureYear);
        }

    }
}
