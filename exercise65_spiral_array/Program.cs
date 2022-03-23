// Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 

Console.Clear();

int[,] arry = new int[10, 10];

SpirallyFillArry(arry.GetLength(0), arry.GetLength(1), arry);
PrntArry(arry);

Console.ReadKey();

void SpirallyFillArry(int row, int column, int[,] arry)
{
    int i, newRow = 0, newColumn = 0, value = 1;
    while (newRow < row && newColumn < column)
    {
        for (i = newColumn; i < column; ++i)
        {
            arry[newRow, i] = value++;
        }
        newRow++;

        for (i = newRow; i < row; ++i)
        {
            arry[i, column - 1] = value++;
        }
        column--;

        if (newRow < row)
        {
            for (i = column - 1; i >= newColumn; --i)
            {
                arry[row - 1, i] = value++;
            }
            row--;
        }

        if (newColumn < column)
        {
            for (i = row - 1; i >= newRow; --i)
            {
                arry[i, newColumn] = value++;
            }
            newColumn++;
        }
    }
}

void PrntArry(int[,] arry)
{
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int column = 0; column < arry.GetLength(1); column++)
        {
            Console.Write(String.Format("{0,3}", arry[row, column]));
        }
        Console.WriteLine();
    }
}