﻿namespace Methods;

public class Helper
{
    public static int[] GenerateArray(int min, int max, int length)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(min, max + 1);
        }
        return array;
    }

    public static void PrintArray(double[] array)
    {
        string message = string.Join(", ", array);
        Console.WriteLine($"[{message}]");
    }

    public static double InputNumber()
    {
        bool isParsed = double.TryParse(Console.ReadLine(), out double number);

        if (isParsed)
        {
            return number;
        }
        else
        {
            throw new ArgumentException("That's not a number");
        }
    }

    public static double InputDoubleNumber(string str)
    {
        Console.WriteLine(str);

        bool isParsed = double.TryParse(Console.ReadLine(), out double number);

        if (isParsed)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Incorrect input...");
            return InputDoubleNumber(str);
        }
    }

    public static int InputIntNumber(string str)
    {
        Console.WriteLine(str);

        bool isParsed = int.TryParse(Console.ReadLine(), out int number);

        if (isParsed)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Incorrect input...");
            return InputIntNumber(str);
        }
    }

    public static void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}    ");
            }
            Console.WriteLine();
        }
    }

    public static void Print2DArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}    ");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
    {
        Random random = new Random();
        int[,] array = new int[countOfRows, countOfColumns];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-10, 11);
            }
        }
        return array;
    }

    public static double[,] GetRandomDouble2DArray(int m, int n)
{
    Random random = new Random();

    double[,] array = new double[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * (100 + 100) - 100, 2); // NextDouble() * (end - begin) + begin
        }
    }
    return array;
}


}
