// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3
/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int getUserData (string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int lenght = getUserData("Введите количество чисел, которое хотите ввести: ");
int [] numbers = new int [lenght];

for (int i = 0; i < lenght; i++)
{
    Console.WriteLine("Введите число: ");
    numbers [i] = int.Parse(Console.ReadLine()!);
}

int PositiveNumbers(int [] array)
{
    int lenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        {
            lenght++;
        }
    }
    return lenght;
}

int positiveNumbersLenght = PositiveNumbers(numbers);
Console.WriteLine($"Количество чисел больше 0 равно {positiveNumbersLenght}");