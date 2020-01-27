using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesMathOps
{
    static class MathOps
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double SqPower(double a)
        {
            return a * a;
        }
    }

    public delegate double BinaryOp(double a, double b);
    public delegate double UnaryOp(double a);
}
