using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of M:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value of N:");
            int n = int.Parse(Console.ReadLine());

            int sum = FindSum(m, n);
            Console.WriteLine("Sum of natural numbers between M and N: " + sum);
            Console.ReadLine();
        }

        static int FindSum(int m, int n)
        {
            if (m > n)
                return 0;
            return m + FindSum(m + 1, n);
        }
    }
}