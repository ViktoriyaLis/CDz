// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

int [] generateArray (int length, int start, int end)
{
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
        
int getUserData (string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int MaxMinDifferents (int [] array)
{
    int min = array[0];
    int max = array[0];
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
    
        } else if (array[i] > max)
        {
            max = array[i];
        }
        result = max - min;
    }
    return result;
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
int Difference = MaxMinDifferents(array);
printArray(array);
Console.Write($"Разница между максимальным и минимальным элементами массива равна {Difference}");