/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

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

int x1 = InputNumber();
int y1 = InputNumber();
int z1 = InputNumber();

int x2 = InputNumber();
int y2 = InputNumber();
int z2 = InputNumber();

double result = GetDistance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Distance between two points: {result}");

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return Math.Round((distance), 2);
}