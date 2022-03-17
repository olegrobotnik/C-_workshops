// В матрице чисел найти сумму элементов главной диагонали.

Console.Clear();
Random rndm = new Random();
int n = rndm.Next(2, 10);
int k = rndm.Next(2, 10);
int[,] arry = new int[n, k];
int sum = 0;

FillArry(arry);
PrntArry(arry);
for (int i = 0; i < arry.GetLength(0); i++)
{
    for (int j = 0; j < arry.GetLength(1); j++)
    {
        if (i == j)
        {
            sum += arry[i, j];
        }
    }
}

Console.WriteLine();
Console.WriteLine($"The sum of matrix's main diagonal is {sum}.");
Console.ReadKey();

void FillArry(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            arry[i, j] = rndm.Next(0, 10);
        }
    }
}

void PrntArry(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{arry[i, j]} ");
                Console.ResetColor();
            }
            else
            {
                Console.Write($"{arry[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}