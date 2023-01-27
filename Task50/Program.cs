/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого элемента в массиве нет
*/

int [,] generate2DDoubleArray (int colLength, int rowLength, int start, int finish)
{
    int [,] array = new int [colLength,rowLength];
    for (int i = 0; i < colLength; i++)
    {   
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, finish+1);
        }
    }
    return array;
}
int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}

void FindElements (int m, int n, int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (m < array.GetLength(0))
        {
           Console.WriteLine($"Искомый элемент {m} есть в массиве");
        }
        else
        {
            Console.WriteLine($"Искомого элемента {m} в массиве нет");
        } 
        if (n > array.GetLength(1))
        {
           Console.WriteLine($"Искомый элемент {n} есть в массиве");
        }
        else
        {
            Console.WriteLine($"Искомого элемента {n} в массиве нет");
        } 
    }
}
int [,] array = generate2DDoubleArray (5,5,0,100);
int m = GetUserData ("Введите искомую строку");
int n = GetUserData ("Введите искомый столбец");
FindElements(m,n,array);
