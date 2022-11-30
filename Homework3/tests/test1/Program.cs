int[] testArray = new int[5];

testArray[0] = 5;
testArray[1] = 6;
testArray[2] = 7;
testArray[3] = 8;
testArray[4] = 9;

//int[] reverseArray = GetReverseArray(testArray);

PrintArray(testArray);
//PrintArray(reverseArray);

void PrintArray(int[] arr)
{
    int index = 0;
    while (index < arr.Length)
    {
        Console.Write($"{arr[index]} ");
        index++;
    }
    Console.WriteLine();
}

int[] GetReverseArray(int[] arr)
{
    int index = 0;
    int size = arr.Length;
    int reverseIndex = size - 1;
    int[] revArr = arr;
    while (index < size)
    {
        revArr[index] = arr[reverseIndex];
        index++;
        reverseIndex = reverseIndex - 1;
    }
    return revArr;
}