// Нап прогрм, принимает на вход цифру, обознач день недели, проверяет,является ли выходным

Console.WriteLine("Введите цифру от 1 до 7");
int number = int.Parse (Console.ReadLine()!);
if (number>0 && number<=7)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да, сегодня выходной");
    }
    else Console.WriteLine("Нет, сегодня рабочий день");
}
else Console.WriteLine("Ошибка. Введите цифру от 1 до 7");