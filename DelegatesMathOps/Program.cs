using System;

namespace DelegatesMathOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Process(1, 2, (x,y) => { return x + y; }));
            Console.WriteLine(Process(1, (x) => { return x * 2; }));
        }

        static double Process(double a, double b, BinaryOp fce)
        {
            return fce(a, b);
        }

        static double Process(double a, UnaryOp fce)
        {
            return fce(a);
        }
    }
}
