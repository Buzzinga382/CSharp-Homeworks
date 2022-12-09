// Пользователь вводит с клавиатуры М чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// 0, 7, 8, -2, -2 -> 2


using static Methods.Helper;

Console.WriteLine("How much numbers you wanna enter?");

bool isParsed = int.TryParse(Console.ReadLine(), out int num);

if (!isParsed || num <= 0)
{
    Console.WriteLine("Incorrect input");
    return;
}

Console.WriteLine($"Ok, please enter your {num} numbers:");

int[] arrayFromConsole;

try
{
    arrayFromConsole = FillArrayFromConsole(num);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

//PrintArray(arrayFromConsole);

int countPositiveNumbers = HowMuchPositiveNumbers(arrayFromConsole);

Console.WriteLine($"You entered {countPositiveNumbers} numbers above zero");






// Methods:

int HowMuchPositiveNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}



int[] FillArrayFromConsole(int num)
{
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = InputNumber();
    }
    return array;
}



int InputNumber()
{
    bool isParsed1 = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed1)
    {
        return number;
    }
    else
    {
        throw new ArgumentException("That's not a number");
    }
}