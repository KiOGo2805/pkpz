using System;

class Program
{
    static int[][] InputJaggedArray()
    {
        Console.Write("Enter number of rows: ");
        int n = int.Parse(Console.ReadLine());

        int[][] jagged = new int[n][];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number of elements in row {i + 1}: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter {m} elements:");
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            jagged[i] = Array.ConvertAll(parts, int.Parse);
        }

        return jagged;
    }


    static int[] CalculateSums(int[][] jagged, int k1, int k2)
    {
        int[] result = new int[jagged.Length];

        for (int i = 0; i < jagged.Length; i++)
        {
            int sum = 0;

            int start = Math.Max(0, k1);
            int end = Math.Min(jagged[i].Length - 1, k2);

            if (start <= end)
            {
                for (int j = start; j <= end; j++)
                {
                    sum += jagged[i][j];
                }
            }

            result[i] = sum;
        }

        return result;
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine("\nResult array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Row {i + 1}: {arr[i]}");
        }
    }

    static void Main()
    {
        int[][] jagged = InputJaggedArray();

        Console.Write("Enter k1: ");
        int k1 = int.Parse(Console.ReadLine());

        Console.Write("Enter k2: ");
        int k2 = int.Parse(Console.ReadLine());

        if (k1 > k2)
        {
            (k2, k1) = (k1, k2);
        }

        int[] result = CalculateSums(jagged, k1, k2);

        PrintArray(result);
    }
}
