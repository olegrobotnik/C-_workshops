// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.Clear();

int M = GetNumber("Enter the inintial number: "), N = GetNumber("Enter the final number: ");
if (M > N)
{
    Console.WriteLine();
    Console.WriteLine("The second number should be greater!");
}
else
{
    Console.WriteLine();
    PrintReqursive(M, N);
}

Console.ReadKey();

int GetNumber(string text)
{
    Console.Write(text);
    string input = Console.ReadLine();
    int.TryParse(input, out int number);
    return number;
}

void PrintReqursive(int M, int N)
{
    if (M <= N)
    {
        Console.Write(M + "|");
        PrintReqursive(M + 1, N);
    }
}