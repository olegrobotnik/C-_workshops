// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

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
    OutptRec(M, N);
}

Console.ReadKey();

int GetNmbr(string txt)
{
    Console.Write(txt);
    string inpt = Console.ReadLine();
    int.TryParse(inpt, out int nmbr);
    return nmbr;
}

void OutptRec(int M, int N)
{
    if (M <= N)
    {
        Console.Write(M + " | ");
        OutptRec(M + 1, N);
    }
}