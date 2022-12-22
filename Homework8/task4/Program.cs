// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static Methods.Helper;


int m = InputIntNumber("Enter first dimension of 3D array:");
int n = InputIntNumber("Enter second dimension of 3D array:");
int l = InputIntNumber("Enter third dimension of 3D array:");
Console.WriteLine();

int[,,] userArray = GenerateRandom2Digit3DArray(m, n, l);

Print3DArrayWithIndices(userArray);

Console.WriteLine();

int[,,] resultArray = GenerateRandom2DigitNotRepeating3DArray(userArray);

Print3DArrayWithIndices(resultArray);






int[,,] GenerateRandom2DigitNotRepeating3DArray(int[,,] array)
{
    Random random = new Random();
    int[,,] newArray = Copy3DArray(array);
    bool alreadyThere;


    for (int x = 0; x < array.GetLength(0);)
    {
        for (int y = 0; y < array.GetLength(1);)
        {
            for (int z = 0; z < array.GetLength(2);)
            {
                alreadyThere = false;
                int newRandomValue = random.Next(10, 100);

                for (int i = 0; i < x; i++)
                {
                    for (int j = 1; j < y; j++)
                    {
                        for (int k = 0; k < z; k++)
                        {
                            if (newArray[i, j, k] == newRandomValue)
                            {
                                alreadyThere = true;
                            }
                        }
                    }
                }

                if (!alreadyThere)
                {
                    newArray[x, y, z] = newRandomValue;
                    x++;
                    y++;
                    z++;
                }
            }
        }
    }

    return newArray;
}


int[,,] GenerateRandom2Digit3DArray(int m, int n, int l)
{
    Random random = new Random();
    int[,,] array = new int[m, n, l];

    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array[j, k, i] = random.Next(10, 100);
            }
        }
    }
    return array;
}