using System;
using System.Text;

namespace Task2
{
    public interface ILogger
    {
        void Event(string message);

        void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(message);

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(message);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}