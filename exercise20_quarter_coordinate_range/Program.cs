// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Shows a coordinate range depends of a quarter.");

int qrtr = Inpt("Enter a quarter number: "); 
QrtrShwr(qrtr);


int Inpt(string msg)
{
    Console.Write(msg);
    int nmbr = int.Parse(Console.ReadLine());
    return nmbr;
}


void QrtrShwr(int qrtr)
{
    if (qrtr == 1)
    {
        Console.WriteLine("The quarter I. Coordinate range x > 0, y > 0");
    }
    else if (qrtr == 2)
    {
        Console.WriteLine("The quarter II. Coordinate range x < 0, y > 0");
    }
    else if (qrtr == 3)
    {
        Console.WriteLine("The quarter III. Coordinate range x < 0, y < 0");
    }
    else if (qrtr == 4)
    {
        Console.WriteLine("The quarter IV. Coordinate range x > 0, y < 0");
    }
    else
    {
        Console.WriteLine("You've entered something else not quarter.");
    }
}