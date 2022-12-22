// Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


using static Methods.Helper;



int[,] array = new int[4, 4];
array = CreateSpiralArray(array);

Print2DArray(array);










int[,] CreateSpiralArray(int[,] arr)
{
    arr[0,0] = 1;
    arr[0,1] = 2;
    arr[0,2] = 3;
    arr[0,3] = 4;

    arr[1,3] = 5;
    arr[2,3] = 6;
    arr[3,3] = 7;
    
    arr[3,2] = 8;
    arr[3,1] = 9;
    arr[3,0] = 10;

    arr[2,0] = 11;
    arr[1,0] = 12;

    arr[1,1] = 13;
    arr[1,2] = 14;

    arr[2,2] = 15;
    arr[2,1] = 16;

    return arr;
}
