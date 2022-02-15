// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Console.Clear();
Console.WriteLine("An array is filled with random zeros and ones and then printed.");
int[,] matrix = new int[4, 2];
FillArry(matrix);
PrntArry(matrix);

void FillArry(int[,] matrix)        // Метод заполнения двумерного массива случайными числами
{
    for (int m = 0; m < matrix.GetLength(0); m += 1)
    {
        for (int n = 0; n < matrix.GetLength(1); n += 1)
        {
            matrix[m,n] = new Random().Next(0,2);
        }
    }
}

void PrntArry(int[,] matrix)         // Метод печати двумерного массива
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


// Console.Clear();         // Ввод и вывод одномерного массива в терминале
// int[] arry = new int[10];
// FillArry(arry);
// PrntArry(arry);

// void FillArry(int[] arry) // Метод заполнения одномерного массива случайными числами
// {
//     //int length = arry.Length;
//     int index = 0;
//     while (index < arry.Length)
//     {
//         arry[index] = new Random().Next(0,10);
//         index++;
//     }
// }

// void PrntArry(int[] arry)  // Метод печати одномерного массива
// {
//     int i = 0;
    
//     foreach (int index in arry)
//     {
//         Console.Write("{0} ", index);
//     }
// }