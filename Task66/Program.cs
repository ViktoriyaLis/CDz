// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}
int SumOfElements(int numberA, int numberB)
{
    int sum = 0;
    if (numberA==numberB)
    {
        sum = numberA;
        return sum;
    }
    sum += numberA + SumOfElements (numberA+1, numberB);
    return sum;
}
int numberA = GetUserData("Введите первое число");
int numberB = GetUserData("Введите второе число");
int result = SumOfElements (numberA,numberB);
Console.WriteLine(result);

