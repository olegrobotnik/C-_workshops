// Найти кубы чисел от 1 до N

Console.WriteLine("Find cubes of numbers from 1 to N");
Console.Write("Please enter a number: ");
int N = int.Parse(Console.ReadLine());
N = Math.Abs(N);
int n = 1;

Console.WriteLine("Num\tCube");
while (n <= N)
{
    Console.WriteLine($"{n}\t{n * n * n}\t");
    n += 1; 
}
