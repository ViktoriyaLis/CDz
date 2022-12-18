// Напис прогр, которая принимает число и выдает является ли оно четным

Console.Clear();

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int b = 0;
if (a%2==b)
{
    Console.WriteLine($" {a} - четное число");
}
if (a%2!=b)
{
    Console.WriteLine($" {a} - нечетное число");
}
