/* Напишите программу, которая принимает на вход два числа (A и B) 
и метод который возводит число A в натуральную степень B. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. 
Не использовать Math.Pow() */

Console.WriteLine("Please enter two numbers");

bool isParse1 = int.TryParse(Console.ReadLine(), out int num1);

if (!isParse1)
{
    Console.WriteLine("Incorrect input");
    return;
}

bool isParse2 = int.TryParse(Console.ReadLine(), out int num2);

if (!isParse2)
{
    Console.WriteLine("Incorrect input");
    return;
}

Console.WriteLine($"{num1} to the power of {num2} equals {PowerOf(num1, num2)}");







// Methods

double PowerOf(int num1, int num2)
{
    double result = num1;

    if (num2 == 0)
    {
        return 1;
    }

    if (num2 == 1)
    {
        return num1;
    }

    if (num2 > 0)
    {
        for (int i = 2; i <= num2; i++)
        {
            result = result * num1;
        }
        return result;
    }
    else
    {
        for (int i = 2; i <= -num2; i++)
        {
            result = result * num1;
        }
        return 1/result;
    }
}