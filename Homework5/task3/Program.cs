/* Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76 */


double[] array = GenerateArray(0, 10, 5);

PrintArray(array);

double diff = GetMinMaxDifference(array);

Console.WriteLine($"Difference between max and min elements is {diff}");










//Methods:

double[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    double[] array = new double[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(random.Next(min, max + 1) + random.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    string message = string.Join(", ", array);
    Console.WriteLine($"[{message}]");
}

double GetMinMaxDifference(double[] array)
{
    int i = 0;
    double min = array[i];
    double max = array[i];

    for (i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return Math.Round(max - min, 2);
}