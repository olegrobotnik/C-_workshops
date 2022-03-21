// Найти произведение двух матриц

Console.Clear();

int n = ChkNmbr("Rows: ");
int k = ChkNmbr("Columns: ");
int[,] mtrxA = new int[n, k];
int[,] mtrxB = new int[k, n];
int[,] mtrxAB = new int[n, n];
Random rndm = new Random();

Console.WriteLine();
Console.WriteLine("Matrix A");
FillPrntArry(mtrxA);
Console.WriteLine();
Console.WriteLine("Matrix B");
FillPrntArry(mtrxB);
Console.WriteLine();
Console.WriteLine("Matrix product");
PrntArry(MtrxMltply(mtrxA, mtrxB, mtrxAB));
Console.ReadKey();

int ChkNmbr(string txt)
{
    int nmbr = 0;
    bool nmbrOrNot = false;
    while (nmbrOrNot == false)
    {
        Console.Write(txt);

        nmbrOrNot = int.TryParse(Console.ReadLine(), out nmbr);
    }
    return nmbr;
}

void FillPrntArry(int[,] arry)
{
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int column = 0; column < arry.GetLength(1); column++)
        {
            arry[row, column] = rndm.Next(0, 10);
            Console.Write($"{arry[row, column]} ");
        }
        Console.WriteLine();
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

int[,] MtrxMltply(int[,] mtrxA, int[,] mtrxB, int[,] mtrxAB)
{
    for (int i = 0; i < mtrxA.GetLength(0); i++)
    {
        for (int j = 0; j < mtrxB.GetLength(1); j++)
        {
            for (int k = 0; k < mtrxB.GetLength(0); k++)
            {
                mtrxAB[i, j] += mtrxA[i, k] * mtrxB[k, j];
            }
        }
    }
    return mtrxAB;
}