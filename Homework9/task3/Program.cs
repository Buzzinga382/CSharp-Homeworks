// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

using static Methods.Helper;


int m = InputIntNumber("Please enter M number:");
int n = InputIntNumber("Please enter N number:");
int howMuchMembers = InputIntNumber("Please enter number of sequence member:");

if (n < 0 || m < 0)
{
    Console.WriteLine("Your number shouldn't be negative");
    return;
}

AckermannFunction(m, n, howMuchMembers);










// Methods:

void AckermannFunction(int m, int n, int members)
{
    Console.Write($"{m + n} ");
    Console.Write($"{m * n} ");
    AlmostAckermannFunction(m, n, members - 2);
}


void AlmostAckermannFunction(int m, int n, int members)
{
    if (members < 1)
    {
        return;
    }

    int res = MtoThePowerOfN(m, n);
    Console.Write($"{res} ");
    AlmostAckermannFunction(m, res, members - 1);

}


int MtoThePowerOfN(int m, int n)
{
    if (n == 1)
    {
        return m;
    }
    int result = m * MtoThePowerOfN(m, n - 1);
    return result;
}