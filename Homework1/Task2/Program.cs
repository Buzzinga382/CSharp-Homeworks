// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Please enter 3 numbers");

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

if (number1 == number2 & number1 == number3)
{
    Console.WriteLine("All numbers are equal");
}

else
{
    int max = number1;
    int min = number1;

    if (number2 > max)
    {
        max = number2;
    }

    else
    {
        min = number2;
    }

    if (number3 > max)
    {
        max = number3;
    }

    else
    {
        if (number3 < min)
        {
            min = number3;
        }
    }

    Console.Write(max);
    Console.WriteLine(" is max number");

    Console.Write(min);
    Console.WriteLine(" is min number");
}

