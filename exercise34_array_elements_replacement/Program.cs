// Написать программу замену элементов массива на противоположные

int[] arry = ArryInit();
Console.Write("Initial array: ");
ArryPrint(arry);
Console.WriteLine();
Console.Write("Reversed array: ");
elmntRplce(arry);


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
    for (int i = 0; i < arry.Length; i++)
    {
        Console.Write(arry[i] + " ");
    }
}


void elmntRplce(int[] arry)                          // Метод замены элементов на отрицательные
{
    foreach (int i in arry)
    {
        Console.Write((i * -1) + " ");
    }
}