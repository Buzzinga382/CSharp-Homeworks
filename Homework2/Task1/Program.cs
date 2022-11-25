/* Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Please enter 3-digit number");

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if(!isParsed)
{
    Console.WriteLine("Incorrect input");
    return;
}

if(number > 999 | number < 100)
{
    Console.WriteLine("Incorrect input");
    return;
}

int thirdDigit = number % 10;
int secondDigit = ((number - thirdDigit)/10) % 10;

Console.WriteLine($"Second digit is {secondDigit}");