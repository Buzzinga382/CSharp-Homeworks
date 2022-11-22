// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Please enter some number");

int number = int.Parse(Console.ReadLine());

int rest = number % 2;

if(rest == 0)
{
    Console.WriteLine("This is even number");
}

else
{
    Console.WriteLine("This is odd number");
}