using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface1
{
    class Calculator : BasicCalculatorInterface, ScientificCalculatorInterface
    {
        public int Division(int x, int y)
        {
            return x / y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }

        public double XtoY(double x, double y)
        {
            double power = Math.Pow(x, y);
            return power;
        }
        public double Cos(int x)
        {
            double cosx = Math.Cos(x);
            return cosx;
        }
    }
}
