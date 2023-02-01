using System;

namespace CountPositiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Введите число " + (i + 1) + ": ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Чисел >0: " + count);
        }
    }
}