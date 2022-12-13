// Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// (1, 7) -> такого элемента в массиве нет

using static Methods.Helper;

int m = InputIntNumber("Please enter the number of rows:");
int n = InputIntNumber("Please enter the number of columns:");

int rowPos = InputIntNumber("Please enter row index:");
int colPos = InputIntNumber("Please enter column index:");

int[,] arr = CreateRandom2DArray(m, n);

(bool, int) result = Find2DArrayElement(arr, rowPos, colPos);

Console.WriteLine();
Console.WriteLine("Here is your array:");
Print2DArray(arr);

if (result.Item1 == false)
{
    Console.WriteLine("There is no elements on your position");
}
else
{
    Console.WriteLine($"Element on your position is [{result.Item2}]");
}


(bool, int) Find2DArrayElement(int[,] array, int rowPosition, int columnPosition)
{


    if (rowPosition >= array.GetLength(0) || columnPosition >= array.GetLength(1))
    {
        return (false, -1);
    }
    else
    {
        return (true, array[rowPosition, columnPosition]);
    }
}