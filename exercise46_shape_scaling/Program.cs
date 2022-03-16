// Написать программу масштабирования фигуры

Console.Clear();
Console.Write("Enter the square scaling factor: ");
int scale = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= scale; i++)
{
    for (int j = 1; j <= scale; j++)
    {
        Console.Write("# ");
    }
    Console.WriteLine();
}
Console.ReadLine();