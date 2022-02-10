// Показать вторую цифру трёхзначного числа

//This is the variant with int variables and division with remainder

int rndm = new Random().Next(100, 1000);
//int dig1 = rndmNmbr / 10;
int dig = (rndm / 10) % 10;

Console.Write("The number is ");
Console.ForegroundColor = ConsoleColor.Green; //Colored output
Console.WriteLine(rndm);
Console.ResetColor();

Console.Write("The second digit is ");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(dig);
Console.ResetColor(); 


//That solution option with a string and a char variables

/* int randomNumber = new Random().Next(100, 1000);
string numberStr = randomNumber.ToString("G");  // General format specifier
char two = numberStr[1];

Console.Write("The number is ");
Console.ForegroundColor = ConsoleColor.Blue; //Colored output
Console.WriteLine(numberStr);
Console.ResetColor();

Console.Write("The second digit is ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(two);
Console.ResetColor(); */