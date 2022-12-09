namespace Methods;

public class Helper
{
    public static int[] GenerateArray(int min, int max, int length)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(min, max + 1);
        }
        return array;
    }

    public static void PrintArray(int[] array)
    {
        string message = string.Join(", ", array);
        Console.WriteLine($"[{message}]");
    }


}
