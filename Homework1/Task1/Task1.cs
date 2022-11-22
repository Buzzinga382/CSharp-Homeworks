// Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Please enter 2 numbers:");

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine("Numbers are equal");
}

else
{
    if (number1 > number2)
    {
        Console.Write(number1);
        Console.WriteLine(" bigger");

        Console.Write(number2);
        Console.WriteLine(" smaller");
    }

    else
    {
        Console.Write(number2);
        Console.WriteLine(" bigger");

        Console.Write(number1);
        Console.WriteLine(" smaller");
    }
}