/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/ 
int getUserValue (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int numberA = getUserValue("Введите первое число");
int numberB = getUserValue("Введите второе число");
Console.Write(Math.Pow(numberA,numberB));


