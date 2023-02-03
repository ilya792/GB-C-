using System;

class Program
{
    static void Main(string[] args)
    {
        int[,,] array = new int[2, 2, 2];

        Console.WriteLine("Enter 8 unique two-digit numbers:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num >= 10 && num <= 99)
                    {
                        array[i, j, k] = num;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter a unique two-digit number:");
                        k--;
                    }
                }
            }
        }

        Console.WriteLine("The 3D array is:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine("array[{0},{1},{2}] = {3}", i, j, k, array[i, j, k]);
                }
            }
        }
    }
}