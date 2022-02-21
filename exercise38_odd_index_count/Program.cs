// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] arry = new int[10];
int sum = 0;
int count = 0;

Console.Write("The array: ");
ArryInit();
RevealSum();


void ArryInit()
{
    for (int i = 0; i < arry.Length; i++)
    {
        arry[i] = new Random().Next(0, 20);
        Console.Write($"{arry[i]} ");
    }

}


void RevealSum()
{
    while (count < arry.Length)
    {
        sum += arry[count];
        count = count + 2;
    }
    Console.WriteLine();
    Console.WriteLine($"The sum of elements with the odd index is {sum}.");
}