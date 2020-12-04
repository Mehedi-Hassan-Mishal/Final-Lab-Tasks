using System;

namespace TestInterface1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(" Sum = " + c.Sum(4, 2));
            Console.WriteLine(" Sub = " + c.Sub(4, 2));
            Console.WriteLine(" Multiplication = " + c.Multiplication(4, 2));
            Console.WriteLine(" Division = " + c.Division(4, 2));
            Console.WriteLine(" Power = " + c.XtoY(4, 2));
            Console.WriteLine("Cos({0}) is:" + c.Cos(0));
        }
    }
}
