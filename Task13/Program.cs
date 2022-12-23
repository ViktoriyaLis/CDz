// Нап прог, выводи третью цифру заданного числа, или сообщает, что ее нет

Console.WriteLine("Введите число");
int number = int.Parse (Console.ReadLine()!);
if (number > 100)
{   int FindDigit(int number)
    {
    int digit1 = number / 100;
    
    return digit1;
    }
    int ThreeDigit = FindDigit(number);
    Console.WriteLine($"Третьей цифрой в числе {number} является {ThreeDigit}");
}
else Console.WriteLine("Третьей цифры нет");
