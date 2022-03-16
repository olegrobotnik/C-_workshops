// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Clear();
Console.WriteLine("Find points of intersect of these straight lines y = k1 * x + b1, y = k2 * x + b2.");
Random rndm = new Random();

double k1 = rndm.Next(-99, 100);
double b1 = rndm.Next(-99, 100);
double k2 = rndm.Next(-99, 100);
double b2 = rndm.Next(-99, 100);

Console.WriteLine($"Set values are: \nk1 = {k1} \nb1 = {b1} \nk2 = {k2} \nb2 = {b2}");

if (k1 == k2)
{
    Console.WriteLine("Straight lines are not intersect.");
}
else
{
    Console.WriteLine($"Points of intersect are: \nx = {((b2 - b1) / (k1 - k2)):N2} \ny = {((k1 * b2 - k2 * b1) / (k1 - k2)):N2}");
} 