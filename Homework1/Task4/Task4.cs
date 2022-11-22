// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Please enter some number");

int number = int.Parse(Console.ReadLine());

int count = 1;

while(count <= number)
{
    int rest = count % 2;
    if(rest == 0)
    {
        Console.Write(count);
        Console.Write(" ");
    }
    count++;
}
Console.WriteLine(" ");