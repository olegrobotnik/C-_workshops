// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

Console.Clear();
Random rndm = new Random();
int m = rndm.Next(5, 9);
int n = rndm.Next(5, 9);
int[,] arry = new int[m, n];

// int[,] arry = new int[5, 5];
// (0, 0) (0, 1) (0, 2) (0, 3) (0, 4)
// (1, 0) (1, 1) (1, 2) (1, 3) (1, 4)
// (2, 0) (2, 1) (2, 2) (2, 3) (2, 4)
// (3, 0) (3, 1) (3, 2) (3, 3) (3, 4)
// (4, 0) (4, 1) (4, 2) (4, 3) (4, 4)

FillArry(arry);
PrntArry(arry);
Console.WriteLine();
SqrElmnt(arry);
PrntArry(arry);

void FillArry(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            arry[i, j] = rndm.Next(2, 9);
        }
    }
}

void PrntArry(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                // Console.ForegroundColor = color;
                // Console.Write($"{arry[i, j]} ");
                // Console.ResetColor();
                PrntColor(i, j);
            }
            else
            {
                Console.Write($"{arry[i, j]} ");
            }
        }

        Console.WriteLine();
    }
}

void SqrElmnt(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                arry[i, j] = arry[i, j] * arry[i, j];
            }
        }
    }
}

void PrntColor(int i, int j)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write($"{arry[i, j]} ");
    Console.ResetColor();
}

void PrntDarkGreen(int i, int j)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write($"{arry[i, j]} ");
    Console.ResetColor();
}