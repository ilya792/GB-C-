using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows in the array:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns in the array:");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, columns];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                Array.Sort(array, i * columns, columns);
            }

            Console.WriteLine("The sorted array is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
        }
    }
}