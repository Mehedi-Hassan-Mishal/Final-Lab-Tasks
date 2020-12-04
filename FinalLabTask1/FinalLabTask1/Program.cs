using System;

namespace FinalLabTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new FixedAccount("111", "Fixed Account", 5000.00, 2015, 5);
            Account a2 = new SavingsAccount("Savings Account", "222", 11000.00, 5);
            Account a3 = new SpecialSavings("Special Saving Account", "333", 20000.00, 5);
            Account a4 = new Overdrafts("Overdrafts Account", "444", 25000.00, 20000.00);


            a1.Withdraw(1000);
            a2.Withdraw(5000);
            a3.Withdraw(11000);
            a4.Withdraw(2000);
            a1.Withdraw(5000);
            a2.Withdraw(20000);
            a3.Withdraw(30000);
            a4.Withdraw(45000);
        }
    }
}
