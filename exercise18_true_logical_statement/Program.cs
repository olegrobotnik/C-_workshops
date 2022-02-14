// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.WriteLine("Find out is the logical statement true or not.");

bool x = false;
bool y = false;
ChckLgicStmnt(x, y);

x = false;
y = true;
ChckLgicStmnt(x, y);

x = true;
y = false;
ChckLgicStmnt(x, y);

x = true;
y = true;
ChckLgicStmnt(x, y);

void ChckLgicStmnt(bool x, bool y) // Метод проверки логического выражения
{
    bool a = !(x && y);
    bool b = (!x || !y);
    if (a == b)
    {
        Console.WriteLine($"\tx = {x} \ty = {y} \t!(x && y)==(!x || !y) is {a == b}");
    }
    else
    {
        Console.WriteLine($"!(x && y)==(!x || !y) is {a == b}");    
    }
}


