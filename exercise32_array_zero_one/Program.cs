// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Console.Clear();
Console.WriteLine("An array is filled with random zeros and ones and then printed.");
int[,] matrix = new int[4, 2];
FillArry(matrix);
PrntArry(matrix);

void FillArry(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m += 1)
    {
        for (int n = 0; n < matrix.GetLength(1); n += 1)
        {
            matrix[m,n] = new Random().Next(0,2);
        }
    }
}

void PrntArry(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            Console.Write($"\t{matrix[m,n]}"); 
        }
        Console.WriteLine();
    }
}