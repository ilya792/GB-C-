using System;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            int value = 1;
            int startRow = 0;
            int endRow = arr.GetLength(0) - 1;
            int startCol = 0;
            int endCol = arr.GetLength(1) - 1;

            while (value <= arr.Length)
            {
                // Right direction
                for (int i = startCol; i <= endCol; i++)
                {
                    arr[startRow, i] = value;
                    value++;
                }

                startRow++;

                // Down direction
                for (int i = startRow; i <= endRow; i++)
                {
                    arr[i, endCol] = value;
                    value++;
                }

                endCol--;

                // Left direction
                for (int i = endCol; i >= startCol; i--)
                {
                    arr[endRow, i] = value;
                    value++;
                }

                endRow--;

                // Up direction
                for (int i = endRow; i >= startRow; i--)
                {
                    arr[i, startCol] = value;
                    value++;
                }

                startCol++;
            }

            // Printing the array
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}