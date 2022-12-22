// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static Methods.Helper;

int m = InputIntNumber("Enter number of rows:");
int n = InputIntNumber("Enter number of columns:");

int[,] userArray = CreateRandom2DArray(m, n);
Print2DArray(userArray);
Console.WriteLine();

int[,] resultArray = SortRowsDescending(userArray);
Print2DArray(resultArray);




int[,] SortRowsDescending(int[,] array)
{
    int[,] sortedArray = Copy2DArray(array);
    int temp = 0;

    for (int k = 0; k < array.GetLength(1); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (sortedArray[i, j + 1] > sortedArray[i, j])
                {
                    temp = sortedArray[i, j + 1];
                    sortedArray[i, j + 1] = sortedArray[i, j];
                    sortedArray[i, j] = temp;
                }
            }
        }
    }
    return sortedArray;
}

// int[] test = GenerateArray(0, 11, 6);
// PrintArray(test);
// int[] res = FindMax(test);
// PrintArray(res);



// int[] FindMax(int[] arr)
// {
//     int[] newArr = new int[arr.Length];
//     int temp = 0;
//     int count = 0;
//     for (int j = count; j < arr.Length; j++)
//     {
//         newArr[j] = arr[j];
//     }

//     while (count < arr.Length)
//     {
//         for (int i = 0; i < arr.Length - 1; i++)
//         {
//             if (newArr[i + 1] > newArr[i])
//             {
//                 temp = newArr[i + 1];
//                 newArr[i + 1] = newArr[i];
//                 newArr[i] = temp;
//             }
//         }
//         count++;
//     }
//     return newArr;
// }




