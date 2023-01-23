// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3
int getUserData (string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
