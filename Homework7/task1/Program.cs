// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


using static Methods.Helper;



int m = InputIntNumber("Please enter the number of rows:");
int n = InputIntNumber("Please enter the number of columns:");

double[,] arr = GetRandomDouble2DArray(m, n);

Console.WriteLine("Here is your array:");
Print2DArray(arr);

