using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ReadNumber();
            CountDown(n);
            Console.ReadLine();
        }

        static int ReadNumber()
        {
            Console.WriteLine("Enter a number N:");
            return int.Parse(Console.ReadLine());
        }

        static void CountDown(int n)
        {
            if (n == 0)
                return;
            Console.WriteLine(n);
            CountDown(n - 1);
        }
    }
}