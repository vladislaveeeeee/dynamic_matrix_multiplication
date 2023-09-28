using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size = ");
            int size = int.Parse(Console.ReadLine());

            int[,] arr = new int[size, size];
            int[,] arr1 = new int[size, size];
            int[,] arr2 = new int[size, size];

            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = rand.Next(10);
                    arr1[i, j] = rand.Next(10);
                }
            }

            Console.WriteLine("Matrix arr:");
            PrintMatrix(arr);

            Console.WriteLine("\nMatrix arr1:");
            PrintMatrix(arr1);

            Console.WriteLine("\nMatrix arr2 (multiplication):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr2[i, j] = arr[i, j] * arr1[i, j];
                    Console.Write(arr2[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}