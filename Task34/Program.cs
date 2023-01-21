// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

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

int FindEvenNumber(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2==0)
       {
        count += 1;
       } 
    }
    return count;
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


int number = getUserData("Введите количество элементов массива");
int [] array = generateArray(number, 100, 999);
int countEvenNumbers = FindEvenNumber(array);
printArray(array);
Console.Write($"Количество четных чисел равно {countEvenNumbers}");
