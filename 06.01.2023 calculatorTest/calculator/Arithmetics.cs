using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Arithmetics
    {
        public static double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public static double Subtract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public static double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public static double Divide(double a, double b)
        {
            double result = a / b;
            return result;
        }
        public static double Power(double a, double b)
        {
            double result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }

    }
}
