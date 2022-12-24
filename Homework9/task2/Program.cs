// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static Methods.Helper;


int n = InputIntNumber("Please enter N number:");
int m = InputIntNumber("Please enter M number:");

if (n <= 0 || m <= 0)
{
    Console.WriteLine("Your number should be bigger than 0");
    return;
}

if (n > m)
{
    int temp = n;
    n = m;
    m = temp;
}

int result = GetSumBetweenNandM(n, m);
Console.WriteLine(result);


int GetSumBetweenNandM(int n, int m)
{

    if (n > m)
    {
        return 0;
    }
    int sum = n + GetSumBetweenNandM(n + 1, m);
    return sum;
}