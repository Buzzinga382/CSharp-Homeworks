/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Please enter some number:");

bool isParse = int.TryParse(Console.ReadLine(), out int num);

if (!isParse)
{
    Console.WriteLine("Incorrect input");
    return;
}

int count = HowMuchNumbers(num);

int[] reverseArray = GetReverseNumbersArray(num, count);

int[] testArray = new int[5];

testArray[0] = 5;
testArray[1] = 6;
testArray[2] = 7;
testArray[3] = 8;
testArray[4] = 9;

int[] straightArray = GetStraightNumbersArray(testArray);

PrintArray(reverseArray);
PrintArray(straightArray);

int HowMuchNumbers(int num)
{
    int result = num / 10;
    int count = 1;
    while (result >= 1)
    {
        result = result / 10;
        count++;
    }
    return count;
}

int[] GetReverseNumbersArray(int num, int count)
{
    int[] array = new int[count];
    int index = 0;
    while (index < count)
    {
        int rest = num % 10;
        array[index] = rest;
        num = num / 10;
        index++;
    }
    return array;
}

int[] GetStraightNumbersArray(int[] arr)
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