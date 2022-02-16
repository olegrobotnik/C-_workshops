// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
int nmbr = Inpt("Enter a whole number: ");
double nmbrCube = 0;

if (nmbr % 2 == 0)
{
    nmbrCube = Math.Pow(nmbr, 3);

    Console.Write("The cube of the number ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(nmbr);
    Console.ResetColor();
    Console.Write(" is ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(nmbrCube);
    Console.ResetColor();
    Console.WriteLine(".");
}
else
{
    Console.Write("The number ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(nmbr);
    Console.ResetColor();
    Console.WriteLine(" is odd.");
}


int Inpt(string msg)                    // Метод ввода числа в терминале с проверкой введённых символов
{
    Console.Write(msg);
    int rslt;
    string str = Console.ReadLine();
    bool succ = int.TryParse(str, out rslt);
    if (succ)
    {
        rslt = Math.Abs(rslt);
        return rslt;
    }
    else
    {
        Console.Write("Please enter valid number. ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(str);
        Console.ResetColor();
        Console.WriteLine(" is not the whole number.");
    }
    return rslt;
}