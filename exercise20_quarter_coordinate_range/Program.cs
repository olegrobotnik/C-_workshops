// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Shows a coordinate range depends of a quarter.");

int qrtr = Inpt("Enter a quarter number: "); 
QrtrShwr(qrtr);


int Inpt(string msg)                    // Метод ввода целого числа в терминале с проверкой введённых символов
{
    int rslt = 0;
    bool succ = false;
    while (succ == false)
    {
        Console.Write(msg);
        string inpt = Console.ReadLine();
        //bool succ = int.TryParse (inpt, out rslt);
        if (int.TryParse(inpt, out rslt))
        {
            succ = 0 < rslt && rslt <= 4;
        }
        else
        {
            Console.WriteLine($"Enter avalid number of a quarter. '{inpt}' is not a number.");
        }
    } 
    return rslt;
}   


void QrtrShwr(int qrtr)
{
    if (qrtr == 1)
    {
        Console.WriteLine("You've entered quarter I. Coordinate range x > 0, y > 0");
    }
    else if (qrtr == 2)
    {
        Console.WriteLine("You've entered quarter II. Coordinate range x < 0, y > 0");
    }
    else if (qrtr == 3)
    {
        Console.WriteLine("The entered quarter III. Coordinate range x < 0, y < 0");
    }
    else if (qrtr == 4)
    {
        Console.WriteLine("The entered quarter IV. Coordinate range x > 0, y < 0");
    }
    else
    {
        Console.WriteLine("You've entered something else not quarter.");
    }
}