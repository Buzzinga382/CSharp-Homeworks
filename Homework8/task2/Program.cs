// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using static Methods.Helper;


int m = InputIntNumber("Enter number of rows:");
int n = InputIntNumber("Enter number of columns:");

int[,] userArray = CreateRandom2DArray(m, n);
Print2DArray(userArray);
Console.WriteLine();

int result = GetRowWithMinSumOfElements(userArray);

Console.WriteLine($"Number of row with minimal sum of elements is {result}");









int GetRowWithMinSumOfElements(int[,] array)
{
    int sum = 0;
    int sumNext = 0;
    int rowNum = -1;
    
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
            sumNext = sumNext + array[i + 1, j];
        }
        if(sum < sumNext)
        {
            rowNum = i;
        }
        else
        {
            rowNum = i + 1;
        }
    }
    return rowNum + 1;
}