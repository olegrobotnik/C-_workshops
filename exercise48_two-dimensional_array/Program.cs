// Показать двумерный массив размером m×n заполненный целыми числами.

Console.Clear();

Random rndm = new Random();
int m = rndm.Next(2, 10);
int n = rndm.Next(2, 10);
int[,] arry = new int[m, n];

FillArry(arry);
PrntArry(arry);

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