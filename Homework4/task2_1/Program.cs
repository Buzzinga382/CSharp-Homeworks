/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Please enter some number");

bool isParse = int.TryParse(Console.ReadLine(), out int num);

if (!isParse)
{
    Console.WriteLine("Incorrect input");
    return;
}

int sum = GetSum(num);

Console.WriteLine($"Sum of digit's of this number is {sum}");








// Methods:

int GetSum(int num)
{
    int sum = 0;
    int rest = 0;

    if (num < 0)
    {
        num = -num;
    }

    while(num >= 1)
    {
        rest = num % 10;
        sum = sum + rest;
        num = num / 10;
    }
    return sum;
}