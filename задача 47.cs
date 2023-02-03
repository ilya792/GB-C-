using System;

namespace TwoDimensionalArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 3;
            int n = 4;

            // Create a 2D array with specified dimensions
            double[,] array2D = new double[m, n];

            // Fill the array with random numbers
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array2D[i, j] = rand.NextDouble();
                }
            }

            // Display the 2D array
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}