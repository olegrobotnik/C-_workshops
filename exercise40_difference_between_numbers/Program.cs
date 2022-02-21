// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] arry = new double[10];
double max = arry[0], min = 0;
Random rndmNmbr = new Random();

for (int i = 0; i < arry.Length; i++)
{
    arry[i] = rndmNmbr.NextDouble();
    if (max >= arry[i])
    {    
    min = arry[i];
    }
    else
    {
        max = arry[i];
    }
    Console.Write($"{arry[i]} ");
}
for (int j = 0; j < arry.Length; j++)
{
    if (min > arry[j])
        min = arry[j];

}


double diff = max - min;
Console.WriteLine();
Console.WriteLine($"The maximal number is {max}.");
Console.WriteLine($"The minimal number is {min}.");
Console.WriteLine($"{max} - {min} = {diff}");