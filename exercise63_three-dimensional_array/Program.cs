// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно 
// на экран выводя индексы соответствующего элемента

Console.Clear();
int[,,] arry = new int[2, 3, 5];
Random rndm = new Random();
FillArry(arry);
PrntArry(arry);
Console.ReadKey();

void FillArry(int[,,] arry)
{
    List<int> list = Enumerable.Range(10, 90).OrderBy(x => rndm.Next()).ToList();
    int i = 0;
    for (int sheet = 0; sheet < arry.GetLength(0); sheet++)
    {
        for (int row = 0; row < arry.GetLength(1); row++)
        {
            for (int column = 0; column < arry.GetLength(2); column++)
            {
                arry[sheet, row, column] = list[i];
                i++;
            }
        }
    }
}

void PrntArry(int[,,] arry)
{
    for (int sheet = 0; sheet < arry.GetLength(0); sheet++)
    {
        Console.WriteLine($"Sheet {sheet + 1}");
        for (int row = 0; row < arry.GetLength(1); row++)
        {
            for (int column = 0; column < arry.GetLength(2); column++)
            {
                Console.Write($"[{sheet}, {row}, {column}] {arry[sheet, row, column]} | ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}