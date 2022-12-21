// Напис прогр, которая принимает число N,на выходе показывает все четные числа от 1 до N

// К сожалению не разобралась, чтобы и цифра 1 отображалась по итогу

Console.Clear();

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int a = 2;
int StartNumber = 1;
if (N > 1)
{
    while (a<=N)
    {
    Console.WriteLine( StartNumber + a + " ");
    a = a+2;
    }
}

