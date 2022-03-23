// Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int[,] arry = new int[2, 10];
Random rndm = new Random();

FillArry(arry);
Console.WriteLine("Initial matrix:");
PrntArry(arry);
Console.WriteLine();
SortArry(arry);
Console.WriteLine("Sorted rows matrix:");
PrntArry(arry);
Console.ReadKey();

void FillArry(int[,] arry)
{
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int column = 0; column < arry.GetLength(1); column++)
        {
            arry[row, column] = rndm.Next(0, 10);
        }
    }
}

void PrntArry(int[,] arry)
{
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int column = 0; column < arry.GetLength(1); column++)
        {
            Console.Write($"{arry[row, column]} "); 
        }
        Console.WriteLine();
    }
}

void SortArry(int[,] arry)
{
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int i = 0; i < arry.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < arry.GetLength(1); j++)
            {
                if (arry[row, i] < arry[row, j])
                {
                    int temp = arry[row, i];
                    arry[row, i] = arry[row, j];
                    arry[row, j] = temp;
                }
            }
        }
    }
}