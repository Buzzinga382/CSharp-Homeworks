/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int num = InputNumber();

int[] array = GetArray(num);

int[] result = GetСubedArray(array);

PrintArray(result);


int[] GetСubedArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = (int)(Math.Pow(index + 1, 3));
        index++;
    }
    return array;
}

void PrintArray(int[] arr)
{
    int index = 0;
    while (index < arr.Length)
    {
        Console.Write($"{arr[index]} ");
        index++;
    }
    Console.WriteLine();
}

int[] GetArray(int num)
{
    int[] array = new int[num];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = index + 1;
        index++;
    }
    return array;
}

int InputNumber()
{
    Console.WriteLine("Please enter some number");
    bool isParse = int.TryParse(Console.ReadLine(), out int num);

    if (isParse)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Incorrect input");
        return -1;
    }
}