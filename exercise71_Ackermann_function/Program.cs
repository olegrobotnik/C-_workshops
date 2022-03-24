// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 29

using System.Numerics;

Console.Clear();

int m = 2;
int n = 3;

Console.WriteLine(Ackermann(m, n));

Console.ReadLine();

BigInteger Ackermann(BigInteger m, BigInteger n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}