/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12//
*/
int GetUserNumber(string message)
{
    Console.WriteLine(message);
    int UserNumber = int.Parse(Console.ReadLine()!);
    return UserNumber;
}
int num = GetUserNumber("Введите число");

int GetDigitSum (int Number)

{
    int sum = 0;
    while (num>=1)  
    {
    int digit  = num %10;
    num = num/10;
    sum += digit;
    }
    return sum;
}
int sum = GetDigitSum (num);

Console.WriteLine ($"Сумма цифр в числе равно {sum} ");