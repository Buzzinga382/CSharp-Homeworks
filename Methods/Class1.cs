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

    public static void PrintArray(double[] array)
    {
        string message = string.Join(", ", array);
        Console.WriteLine($"[{message}]");
    }

    public static double InputNumber()
    {
        bool isParsed = double.TryParse(Console.ReadLine(), out double number);

        if (isParsed)
        {
            return number;
        }
        else
        {
            throw new ArgumentException("That's not a number");
        }
    }


}
