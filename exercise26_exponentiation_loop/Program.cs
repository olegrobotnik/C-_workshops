// Возведите число А в натуральную степень B используя цикл

Console.Clear();

Console.WriteLine("An entered random number is raised to an entered power which is the natural number.");

int A = InptA("Enter the number to be raised to a power: ");
int B = InptB("Enter a power that a number to be raised to: ");

Console.WriteLine(A + " was raised to " + B);
//Console.WriteLine(B);
int exp = Exponentiation(A, B);
Console.Write(exp);


int InptA(string msg)                    // Метод ввода числа в терминале с проверкой введённых символов
{
    Console.Write(msg);
    int rslt;
    string str = Console.ReadLine();
    bool succ = int.TryParse (str, out rslt);
    if (succ)
    {
        return rslt;
    }    
    else 
    {
        Console.WriteLine($"Please enter a valid number. '{str}' is not the natural number.");
    }
    return rslt;
}


int InptB(string msg)                    // Метод ввода числа в терминале с проверкой введённых символов
{
    Console.Write(msg);
    int rslt;
    string str = Console.ReadLine();
    bool succ = int.TryParse (str, out rslt);
    if (succ)
    {
        rslt = Math.Abs(rslt);
        //return rslt;
    }    
    else 
    {
        Console.WriteLine($"Please enter a valid number. '{str}' is not the natural number.");
    }
    return rslt;
}


int Exponentiation(int A, int B)
{
    int exp = 1;
    for (int i = 0; i < B; i++)
    {
        exp = exp * A;
    }
    return exp;
}
