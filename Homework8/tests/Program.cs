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