// Определить сколько чисел больше 0 введено с клавиатуры

Console.Clear();
Console.Write("Please enter a positive number: ");

int count = 0;

while (true)
{
    bool rslt = int.TryParse(Console.ReadLine(), out int nmbr);
    if (rslt && nmbr > 0)
    {
        count++;
    }
    else break;
}

Console.WriteLine($"You've entered {count} positive numbers.");