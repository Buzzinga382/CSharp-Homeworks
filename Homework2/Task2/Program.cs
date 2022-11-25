/* Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Please enter some number");

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Incorrect input");
    return;
}

if (number < 100 & number > -100)
{
    Console.WriteLine("There is no 3rd digit");
    return;
}

while (number >= 1000 | number <= -1000)
{
    number = number / 10;
}

int thirdDigit = number % 10;

if (thirdDigit < 0)
{
    thirdDigit = -thirdDigit;
}

Console.WriteLine($"Third digit is {thirdDigit}");