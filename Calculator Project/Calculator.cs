using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Project
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            int total = 0;

            foreach (int number in numbers)
            {
                total = total + number;
            }
            return total;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(double a, int b)
        {
            return a / b;
        }

        public double Exponents(double a, long b)
        {
            return Math.Pow(a, b);
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }

    }
}
