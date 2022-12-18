// Напис. программу, которая принимает 3 числа и выдает максимальное из них

Console.Clear();

Console.WriteLine("Введите первое число");
int a = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int c = int.Parse (Console.ReadLine()!);
int max = a;
if (a>max)
{
    max=a;
}

if (b>max) 
{
    max = b;
}

if (c>max) 
{
    max = c;
}
Console.WriteLine(max);