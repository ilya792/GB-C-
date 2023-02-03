using System;

namespace ArrayElementAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
            Console.WriteLine("Enter the row number (0-based index) of the element: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column number (0-based index) of the element: ");
            int col = int.Parse(Console.ReadLine());
            if (row >= 0 && row < arr.GetLength(0) && col >= 0 && col < arr.GetLength(1))
            {
                Console.WriteLine("The element at position [" + row + "," + col + "] is: " + arr[row, col]);
            }
            else
            {
                Console.WriteLine("There is no such element in the array.");
            }
        }
    }
}