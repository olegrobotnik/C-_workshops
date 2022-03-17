// В двумерном массиве n×k заменить четные элементы на противоположные.

Console.Clear();
Random rndm = new Random();
int n = rndm.Next(2, 10);
int k = rndm.Next(2, 10);
int[,] arry = new int[n, k];

FillArry(arry);
PrntArry(arry);
Console.WriteLine();
EvenToNgtive(arry);
PrntArry(arry);
Console.ReadLine();

void FillArry(int[,] arry)
{
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int column = 0; column < arry.GetLength(1); column++)
        {
            arry[row, column] = rndm.Next(-99, 100);
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

void EvenToNgtive(int[,] arry)
{
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int column = 0; column < arry.GetLength(1); column++)
        {
            if (arry[row, column] % 2 == 0)
            {
                arry[row, column] = arry[row, column] * -1;
            }
        }
    }
}