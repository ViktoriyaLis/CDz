// Нап программу, принимает на вход трехзн число, на выходе показывает вторую цифру числа

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);
int FindDigit(int number)
{
    int digit1 = number / 10;
    int digit2 = digit1 % 10;
    return digit2;
}
int SecondDigit = FindDigit(number);
Console.WriteLine($"В числе {number} второй цифрой является {SecondDigit}");
