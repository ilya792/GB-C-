using System;

namespace MinRowSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] 
            {
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4},
                {5, 2, 6, 7}
            };

            int minRow = 0;
            int minSum = int.MaxValue;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
                if (sum < minSum)
                {
                    minSum = sum;
                    minRow = i;
                }
            }

            Console.WriteLine("Row with minimum sum is row " + (minRow + 1));
        }
    }
}