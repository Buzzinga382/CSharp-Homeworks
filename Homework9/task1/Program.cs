// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static Methods.Helper;



int n = InputIntNumber("Please enter start number:");
// int m = InputIntNumber("Please enter end number:");

// if (m > n)
// {
//     Console.WriteLine("End number should be smaller than start number");
// }

if (n <= 1)
{
    Console.WriteLine("Your number should be bigger than 1");
    return;
}

GetNtoMNumbers(n, 1);
Console.WriteLine();





void GetNtoMNumbers(int n, int m)
{
    if (n < m)
    {
        return;
    }
    Console.Write($"{n} ");
    GetNtoMNumbers(n - 1, m);
}