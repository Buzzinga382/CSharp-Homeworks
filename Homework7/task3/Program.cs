// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static Methods.Helper;


int m = InputIntNumber("Please enter the number of rows:");
int n = InputIntNumber("Please enter the number of columns:");

int[,] arr = CreateRandom2DArray(m, n);

double[] average = GetAverageOfColumnsNumbers(arr);

Console.WriteLine();
Console.WriteLine("Here is your array:");
Print2DArray(arr);

Console.WriteLine();
Console.WriteLine("Average of each column is:");
PrintArray(average);



double[] GetAverageOfColumnsNumbers(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    int j = 0;

    while (j < array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            newArray[j] = newArray[j] + array[i, j];
        }
        newArray[j] = Math.Round(newArray[j] / array.GetLength(0), 2);
        j++;
    }
    return newArray;
}