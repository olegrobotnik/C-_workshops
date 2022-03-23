// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int M = GetNmbr("Enter the inintial number: "), N = GetNmbr("Enter the final number: ");
if (M > N)
{
    Console.WriteLine();
    Console.WriteLine("The second number should be greater!");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"The sum of natural numbers from {M} to {N} is {SumRec(M, N)}.");
}

Console.ReadKey();

int GetNmbr(string txt)
{
    Console.Write(txt);
    string inpt = Console.ReadLine();
    int.TryParse(inpt, out int nmbr);
    return nmbr;
}

int SumRec(int M, int N)
{
    if (M <= N)
    {
        return M += SumRec(M + 1, N);
    }
    else
    {
        return 0;
    }
}