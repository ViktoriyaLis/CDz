/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12//
*/
int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}
int sum = 0;
int FindDigit (int sum)
{
    
    int digit = 0;
    while (digit >=0)
    {
        digit = digit / 10;
        digit++;
    }
    if (num > digit)
    {
        for (int i = 1; i<= num; i++)
        {
            sum += digit;
        }
    }
    return sum;
}


//int GetSumDigit(int num)
{
    
    int sum = 0;
    for (int i = 1; i<= num; i++)
    {
        temp += digit;
    }
    return temp;
}

int num = GetUserData("Введите число");
int cifra = FindDigit(sum);
//int result = GetSumDigit (temp);
Console.WriteLine($"Сумма цифр в {num} = {cifra}");

