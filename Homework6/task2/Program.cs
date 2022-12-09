// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


using static Methods.Helper;

Console.WriteLine("Please enter b1:");
double b1;
try
{
    b1 = InputNumber();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    return;
}
Console.WriteLine("Please enter k1:");
double k1;
try
{
    k1 = InputNumber();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

Console.WriteLine("Please enter b2:");
double b2;
try
{
    b2 = InputNumber();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    return;
}
Console.WriteLine("Please enter k2:");
double k2;
try
{
    k2 = InputNumber();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Lines are parallel");
    return;
}

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Lines coincide");
    return;
}

double[] arr = IntersectionPoint(b1, k1, b2, k2);

Console.Write($"The intersection point is ");
PrintArray(arr);





// Method:

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * (b2 - b1) / (k1 - k2) + b1, 2);

    array[0] = x;
    array[1] = y;

    return array;
}

