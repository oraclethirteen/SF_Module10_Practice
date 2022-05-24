using System;
using System.Text;
using System.Threading;

namespace Task2
{
    interface ICalculator
    {
        double Sum(double a, double b);

        double NumRead();

        void ShowResult(double result);
    }

    class Calculator : ICalculator
    {
        private ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        double ICalculator.Sum(double a, double b)
        {
            Logger.Event("\nКалькулятор выполняет сложение...");

            Thread.Sleep(200);

            return a + b;
        }

        double ICalculator.NumRead()
        {
            string readNum = Console.ReadLine();

            Logger.Event("\nОбработка запроса...");

            Thread.Sleep(500);

            return Convert.ToDouble(readNum);
        }

        void ICalculator.ShowResult(double result)
        {
            Console.WriteLine("\nРезультат вычисления: {0}\n", result);
        }


    }
}