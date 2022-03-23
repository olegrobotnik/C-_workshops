// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();
int[,] arry = new int[7, 2];
Random rndm = new Random();

FillArry(arry);
PrntArry(arry);
Console.WriteLine();
SumRow(arry);
Console.WriteLine();

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

void SumRow(int[,] arry)
{
    int minSumRow = 0;
    int minSumRowIndex = 0;
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        int sum = 0;
        for (int column = 0; column < arry.GetLength(1); column++)
        {
            sum += arry[row, column];
        }
        Console.WriteLine($"The row {row} sum = {sum}");
        if (row == 0)
        {
            minSumRow = sum;
        }
        else if (sum < minSumRow)
        {
            minSumRow = sum;
            minSumRowIndex = row;
        }
    }
    Console.WriteLine();
    Console.Write($"The row with the minimum sum of elements is {minSumRowIndex}.");
}