// Возведите число А в натуральную степень B используя цикл

Console.Clear();

Console.WriteLine("An entered random number is raised to an entered power which is the natural number.");

double A = InptA("Enter a number to be raised to a power: ");
int B = InptB("Enter a power that a number to be raised to: ");

Console.Write("The number ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(A);
Console.ResetColor();
Console.Write(" raised to the power ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(B); 
Console.ResetColor();
Console.WriteLine(".");

double exp = Exponentiation(A, B);

Console.Write($"The result is ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(exp);
Console.ResetColor();
Console.Write(".");


double InptA(string msg)                    // Метод ввода вещественного числа в терминале с проверкой введённых символов
{
    Console.Write(msg);
    string str = Console.ReadLine();
    double rslt = 0;
    bool succBool = double.TryParse(str, out rslt);
    if (succBool)
    {
        return rslt; 
    }    
    else 
    {
        Console.WriteLine($"Please enter a valid number. '{str}' is not the natural number.");
    }
    return rslt;
}


int InptB(string msg)                    // Метод ввода натурального числа в терминале с проверкой введённых символов
{
    Console.Write(msg);
    int rslt;
    string str = Console.ReadLine();
    bool succ = int.TryParse (str, out rslt);
    if (succ)
    {
        rslt = Math.Abs(rslt);
        return rslt;
    }    
    else 
    {
        Console.WriteLine($"Please enter a valid number. '{str}' is not the natural number.");
    }
    return rslt;
}


double Exponentiation(double A, int B)
{
    double exp = 1;
    for (int i = 0; i < B; i++)
    {
        exp = exp * A;
    }
    return exp;
}