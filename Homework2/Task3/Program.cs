/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Please enter number of week day");

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Incorrect input");
    return;
}

if (number < 1 | number > 7)
{
    Console.WriteLine("Incorrect input");
    return;
}

if (number == 6 | number == 7)
{
    Console.WriteLine("Yes, it's a day off");
}
else
{
    Console.WriteLine("No, it's not a day off");
}