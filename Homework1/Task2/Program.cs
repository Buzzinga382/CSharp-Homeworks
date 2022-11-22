// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Please enter 3 numbers");

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

int max = number1;
int min = number1;

if(number2>max)
{
    max = number2;
}

if(number3>max)