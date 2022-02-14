// Найти расстояние между точками в пространстве 2D/3D

// AB2D = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
// AB3D = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));

Console.WriteLine("Calculate a distance between two points in 2D, 3D spaces.");

Console.Write("Select number of dimensions by typing 2 or 3: ");
string select = Console.ReadLine();
if (select == "2")
{
    Console.Write("Enter the xa coordinate: ");
    int xa = int.Parse(Console.ReadLine());
    Console.Write("Enter the ya coordinate: ");
    int ya = int.Parse(Console.ReadLine());
    Console.Write("Enter the xb coordinate: ");
    int xb = int.Parse(Console.ReadLine());
    Console.Write("Enter the yb coordinate: ");
    int yb = int.Parse(Console.ReadLine());
    Console.Write($"The distance between two points is {Dist2D(xa, ya, xb, yb)}.");
}
else if (select == "3")
{
    Console.Write("Enter the xa coordinate: ");
    int xa = int.Parse(Console.ReadLine());
    Console.Write("Enter the ya coordinate: ");
    int ya = int.Parse(Console.ReadLine());
    Console.Write("Enter the za coordinate: ");
    int za = int.Parse(Console.ReadLine());
    Console.Write("Enter the xb coordinate: ");
    int xb = int.Parse(Console.ReadLine());
    Console.Write("Enter the yb coordinate: ");
    int yb = int.Parse(Console.ReadLine());
    Console.Write("Enter the zb coordinate: ");
    int zb = int.Parse(Console.ReadLine());
    Console.Write($"The distance between two points is {Dist3D(xa, ya, za, xb, yb, zb)}.");
}
else
{
    Console.WriteLine("Input is not correct.");
}


double Dist2D(int xa, int ya, int xb, int yb)                        // Метод вычисления расстояния между точками в 2D
{
    double dist = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
    return dist;
}


double Dist3D(int xa, int ya, int za, int xb, int yb, int zb)         // Метод вычисления расстояния между точками в 2D
{
    double dist = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
    return dist;
}