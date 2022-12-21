// Напис прогр, которая принимает число N,на выходе показывает все четные числа от 1 до N

// К сожалению не разобралась c этой задачей
Console.Clear();

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int a = 2;
int StartNumber = 1;
while (a<=N)
        if (a%2==0)
        {
         Console.WriteLine( StartNumber +  " ");
        a = a+1;
        }
else a++;

