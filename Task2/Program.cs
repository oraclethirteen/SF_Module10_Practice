using System;
using System.Threading;

namespace Task2
{
    class Program
    {
        private static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("\t***МИНИ-КАЛЬКУЛЯТОР (СЛОЖЕНИЕ) [EVENTS]***");

            while (true)
            {
                double result = 0;

                Logger = new Logger();
                ICalculator calculator = new Calculator(Logger);

                try
                {
                    Console.Write("\nПервое число: ");
                    double a = calculator.NumRead();

                    Console.Write("\nВторое число: ");
                    double b = calculator.NumRead();

                    Thread.Sleep(500);

                    result = calculator.Sum(a, b);

                    Thread.Sleep(1000);

                    calculator.ShowResult(result);
                }
                catch (FormatException fEx)
                {
                    Logger.Error("\nНекорректное число!\n");
                    Logger.Error(fEx.Message);
                    Console.WriteLine();
                }
                catch (OverflowException oEx)
                {
                    Logger.Error("\nЧисло за пределами допустимого значения!\n");
                    Logger.Error(oEx.Message);
                    Console.WriteLine();
                }
                catch (Exception Ex)
                {
                    Logger.Error("\nНепредвиденная ошибка!\n");
                    Logger.Error(Ex.Message);
                    Console.WriteLine();
                }
                finally
                {
                    Console.WriteLine("Для выхода из программы нажмите 'ESC'...");

                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}