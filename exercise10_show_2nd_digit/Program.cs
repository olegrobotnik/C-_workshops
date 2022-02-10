// Показать вторую цифру трёхзначного числа

//That solution option with a string and a char variables

int randomNumber = new Random().Next(100, 1000);
string numberStr = randomNumber.ToString("G");  // General format specifier
char two = numberStr[1];

Console.Write("The number is ");
Console.ForegroundColor = ConsoleColor.Blue; //Colored output
Console.WriteLine(numberStr);
Console.ResetColor();

Console.Write("The second digit is ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(two);
Console.ResetColor();