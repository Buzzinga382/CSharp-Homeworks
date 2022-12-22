// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static Methods.Helper;


int m = InputIntNumber("Enter number of columns for matrix A and number of rows for matrix B:");
int n = InputIntNumber("Enter number of rows for matrix A:");
int l = InputIntNumber("Enter number of columns for matrix B:");
Console.WriteLine();

int[,] matrixA = CreateRandom2DArray(n, m);
int[,] matrixB = CreateRandom2DArray(m, l);

Console.WriteLine("Matrix A:");
Print2DArray(matrixA);
Console.WriteLine();
Console.WriteLine("Matrix B:");
Print2DArray(matrixB);
Console.WriteLine();

int[,] matrixC = ProductOfTwoMatrices(matrixA, matrixB);
Console.WriteLine("Product of matrix A and matrix B:");
Print2DArray(matrixC);







int[,] ProductOfTwoMatrices(int[,] matA, int[,] matB)
{
    int[,] matC = new int[matA.GetLength(0), matB.GetLength(1)];

    for (int k = 0; k < matC.GetLength(0); k++)
    {
        for (int l = 0; l < matC.GetLength(1); l++)
        {
            for (int j = 0; j < matA.GetLength(1); j++)
            {
                matC[k, l] = matC[k, l] + matA[k, j] * matB[j, l];
            }
        }
    }
    return matC;
}