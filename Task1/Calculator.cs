using System;
using System.Text;

namespace Task1
{
    interface ICalculator
    {
        double Sum(double a, double b);

        double NumRead();

        void ShowResult(double result);
    }

    class Calculator : ICalculator
    {
        double ICalculator.Sum(double a, double b)
        {
            return a + b;
        }

        double ICalculator.NumRead()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        void ICalculator.ShowResult(double result)
        {
            Console.WriteLine("\nРезультат вычисления: {0}\n", result);
        }
    }
}