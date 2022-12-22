using static Methods.Helper;



int m = InputIntNumber("Enter some number");

int[] userArray = GenerateArray(0, 21, m);

PrintArray(userArray);

int[] result = GetUniqueRandomArray(userArray);

PrintArray(result);


int[] GetUniqueRandomArray(int[] array)
{
    Random random = new Random();
    int[] newArray = CopyArray(array);
    bool alreadyThere;


    for (int i = 0; i < array.Length;)
    {
        alreadyThere = false;
        int newRandomValue = random.Next(1, 21);

        for (int j = 0; j < i; j++)
        {
            if(newArray[j] == newRandomValue)
            {
                alreadyThere = true;
                break;
            }
        }

        if(!alreadyThere)
        {
            newArray[i] = newRandomValue;
            i++;
        }
    }
    return newArray;
    
}



int[] CopyArray(int[] arr)
{
    int[] copiedArray = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        copiedArray[i] = arr[i];
    }
    return copiedArray;
}




int[,] array = new int[4, 4];
array = CreateSpiralArray(array);

Print2DArray(array);





int[,] CreateSpiralArray(int[,] arr)
{
    Random random = new Random();

    for (int i = 0; i < arr.GetLength(0) / 2 && i < arr.GetLength(1) / 2; i++)
    {
        for (int j = i; j < arr.GetLength(1) - i; j++)
        {
            arr[i, j] = random.Next(1, 5);
        }
        Print2DArray(array);
        Console.WriteLine();

        for (int k = i + 1; k < arr.GetLength(0) - i; k++)
        {
            arr[k, arr.GetLength(1) - 1 - i] = random.Next(1, 5);
        }
        Print2DArray(array);
        Console.WriteLine();

        for (int l = arr.GetLength(1) - i - 2; l >= 0; l--)
        {
            arr[arr.GetLength(0) - 1 - i, l] = random.Next(1, 5);
        }
        Print2DArray(array);
        Console.WriteLine();


        for (int m = arr.GetLength(0) - i - 2; m > 0 + i; m--)
        {
            arr[m, 0 + i] = random.Next(1, 5);
        }
        Print2DArray(array);
        Console.WriteLine();
    }
    return arr;

}