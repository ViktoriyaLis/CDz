/*
Задача 43: Напишите программу, которая найдёт точку пересечения
двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5,
b2 = 4, k2 = 9
-> (-0,5; -0,5)
*/

int getUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int b1 = getUserData ("Введите значение b1: ");
int k1 = getUserData ("Введите значение k1: ");
int b2 = getUserData ("Введите значение b2: ");
int k2 = getUserData ("Введите значение k2: ");
int x = (-b1 + b2) / (-k1 + k2); 
int y = k1 * x + b1;
Console.WriteLine($"точка пересечения прямых в точке ({x}; {y})");

void DotsPoint (int b1, int k1, int b2, int k2)
{
    if(k1==k2 && b1==b2)
    {
        Console.WriteLine("прямые равны");
    }
    else if (k1==k2)
    {
        Console.WriteLine("прямые параллельны");
    }
}
