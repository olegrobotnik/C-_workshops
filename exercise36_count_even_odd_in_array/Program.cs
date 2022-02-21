// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] arry = ArryInit();
int odd = 0;
int even = 0;

Console.Write("The array: ");
ArryPrint(arry);

for (int i = 0; i < arry.Length; i++)
{
    if (arry[i] % 2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
}

Console.WriteLine();
Console.WriteLine($"The number of even elements in the array is {even}.");
Console.WriteLine($"The number of odd elements in the array is {odd}.");


int[] ArryInit()                                    // Метод ввода массива
{
    int[] arry = new int[10];
    Random rndmNmbr = new Random();
    int i = 0;
    while (i < arry.Length)
    {
        arry[i] = rndmNmbr.Next(0, 1000);
        i++;
    }
    return arry;
}


void ArryPrint(int[] arry)                           // Метод печати массива
{
    foreach (int i in arry)
    {
        Console.Write(i + " ");
    }
}