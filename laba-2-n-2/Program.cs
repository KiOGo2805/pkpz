using System;

class Program
{
    static int[,] FillMatrix(int n)
    {
        Random rand = new();
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                matrix[i, j] = rand.Next(-50, 50);
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        Console.WriteLine("\nMatrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write($"{matrix[i, j],4}");
            Console.WriteLine();
        }
    }

    static void CheckRows(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        Console.WriteLine("\nRows with all identical elements:");
        bool found = false;
        for (int i = 0; i < n; i++)
        {
            bool allEqual = true;
            for (int j = 1; j < n; j++)
            {
                if (matrix[i, j] != matrix[i, 0])
                {
                    allEqual = false;
                    break;
                }
            }
            if (allEqual)
            {
                Console.WriteLine($"Row {i}");
                found = true;
            }
        }
        if (!found) Console.WriteLine("None");
    }

    static void CheckCols(int[,] matrix)
    {
        int n = matrix.GetLength(1);
        Console.WriteLine("\nColumns with all even elements:");
        bool found = false;
        for (int j = 0; j < n; j++)
        {
            bool allEven = true;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] % 2 != 0)
                {
                    allEven = false;
                    break;
                }
            }
            if (allEven)
            {
                Console.WriteLine($"Column {j}");
                found = true;
            }
        }
        if (!found) Console.WriteLine("None");
    }

    static void Main()
    {
        Console.Write("Enter matrix size n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = FillMatrix(n);

        PrintMatrix(matrix);
        CheckRows(matrix);
        CheckCols(matrix);
    }
}
