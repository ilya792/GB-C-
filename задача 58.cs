using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = new int[,] { { 2, 4 }, { 3, 2 } };
            int[,] secondMatrix = new int[,] { { 3, 4 }, { 3, 3 } };
            int[,] result = MultiplyMatrices(firstMatrix, secondMatrix);

            Console.WriteLine("Result of matrix multiplication:");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
        {
            int rowsInFirstMatrix = firstMatrix.GetLength(0);
            int columnsInFirstMatrix = firstMatrix.GetLength(1);
            int rowsInSecondMatrix = secondMatrix.GetLength(0);
            int columnsInSecondMatrix = secondMatrix.GetLength(1);
            int[,] result = new int[rowsInFirstMatrix, columnsInSecondMatrix];

            if (columnsInFirstMatrix != rowsInSecondMatrix)
            {
                Console.WriteLine("Number of columns in first matrix should be equal to number of rows in second matrix.");
                return null;
            }

            for (int i = 0; i < rowsInFirstMatrix; i++)
            {
                for (int j = 0; j < columnsInSecondMatrix; j++)
                {
                    for (int k = 0; k < columnsInFirstMatrix; k++)
                    {
                        result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }
            return result;
        }
    }
}