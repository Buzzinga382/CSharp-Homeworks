/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.WriteLine("How much elements you want in your array?");

bool isParse = int.TryParse(Console.ReadLine(), out int num);

if (!isParse)
{
    Console.WriteLine("Incorrect input");
    return;
}

int[] array = GetArray(num);

Console.Write("That is your array: ");

PrintArray(array);










// Methods:

int[] GetArray(int num)
{
    Console.WriteLine($"Please enter all {num} elements:");

    int[] array = new int[num];
    int index = 0;

    while (index < array.Length)
    {
        bool isParse1 = int.TryParse(Console.ReadLine(), out int number);

        if (!isParse1)
        {
            Console.WriteLine("Incorrect input");
            break;
        }

        array[index] = number;
        index++;
    }
    return array;
}

void PrintArray(int[] arr)
{
    int index = 0;
    while (index < arr.Length - 1)
    {
        Console.Write($"{arr[index]}, ");
        index++;
    }
    Console.Write($"{arr[arr.Length - 1]}.");
    Console.WriteLine();
}


