/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Please enter some number");

bool isParse1 = int.TryParse(Console.ReadLine(), out int num);

if (!isParse1)
{
    Console.WriteLine("Incorrect input");
    return;
}

int count = Count(num);

int[] array = ArrayOfNumbers(num, count);

int sum = Sum(array);

Console.WriteLine($"Sum of digit's of this number is {sum}");








// Methods:

int Count(int num)
{
    int count = 0;

    if(num < 0)
    {
        num = -num;
    }

    while (num >= 1)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int[] ArrayOfNumbers(int num, int count)
{
    int[] array = new int[count];
    int rest = 0;
    int index = 0;

    if(num < 0)
    {
        num = -num;
    }

    while (index < count)
    {
        rest = num % 10;
        array[index] = rest;
        num = num / 10;
        index++;
    }
    return array;
}

int Sum(int[] arr)
{
    int index = 0;
    int sum = 0;

    while (index < arr.Length)
    {
        sum = sum + arr[index];
        index++;
    }
    return sum;
}