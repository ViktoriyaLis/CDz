// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

int [] generateArray (int length, int start, int end)
{
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

int getUserData(string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int FindSumOfUnevenElements(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++) //почему-то неверно считает нечетные индексы
    {
       if (array[i]%2!=0)
       {
        sum += array[i];
       } 
    }
    return sum;
}
void printArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1)
        {
            Console.Write($", ");
        }
    
    }
    Console.WriteLine($"]");
}

int number = getUserData("Введите количество элементов в массиве");
int [] array = generateArray(number, 1, 99);
int sum = FindSumOfUnevenElements(array);
printArray(array);
Console.Write($"Количество элементов на нечетных позициях равно {sum}");