/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
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

int[] straightArray = GetStraightArray(num, count);

//PrintArray(reverseArray);
//PrintArray(straightArray);

int check = CheckEquality(reverseArray, straightArray);

if (check == 1)
{
    Console.WriteLine("Yes, it's a palindrome");
}
else
{
    Console.WriteLine("No, it's not a palindrome");
}










// Methods:

int CheckEquality(int[] array1, int[] array2)
{
    int index = 0;
    int check = -1;
    while (index < array1.Length)
    {
        if (array1[index] == array2[index])
        {
            check = 1;
            index++;
        }
        else
        {
            check = 0;
            break;
        }
    }
    return check;
}

int[] GetStraightArray(int num, int count)
{
    int[] array = new int[count];
    int index = 0;
    int newIndex = count - 1;
    while (index < count)
    {
        int rest = num % 10;
        array[newIndex] = rest;
        num = num / 10;
        index++;
        newIndex = newIndex - 1;
    }
    return array;
}

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

