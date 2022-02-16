// Подсчитать сумму цифр в числе

Console.Clear();
int nmbr = Inpt("Enter a whole number: ");
int nmbrDiv = nmbr;
int digSum = 0;

while (nmbrDiv > 0)
{
    digSum = digSum + (nmbrDiv % 10);
    nmbrDiv = nmbrDiv / 10;
}

Console.Write("The sum of digits is ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{digSum}.");
Console.ResetColor();


int Inpt(string msg)                    // Метод ввода числа в терминале с проверкой введённых символов
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
        Console.Write("Please enter valid number. "); 
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(str);
        Console.ResetColor();
        Console.WriteLine(" is not the whole number.");
    }
    return rslt;
}