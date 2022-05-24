using System;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t***МИНИ-КАЛЬКУЛЯТОР (СЛОЖЕНИЕ)***");

            while (true)
            {
                try
                {
                    double result = 0;

                    ICalculator calculator = new Calculator();

                    Console.Write("\nПервое число: ");
                    double a = calculator.NumRead();

                    Console.Write("Второе число: ");
                    double b = calculator.NumRead();

                    result = calculator.Sum(a, b);

                    calculator.ShowResult(result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nНекорректное число!\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nЧисло за пределами допустимого значения!\n");
                }
                catch (Exception)
                {
                    Console.WriteLine("\nНепредвиденная ошибка!\n");
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