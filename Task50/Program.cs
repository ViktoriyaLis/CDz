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
/*void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(data);
    Console.ResetColor();
}
*/
void print2DArray (int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " \t");
        }
        Console.WriteLine();
    }
}
void FindElement (int m, int [,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (m == array [i,j])
            {
                int result = 0;
                result+= array[i,j];
                Console.WriteLine($"Элемент находится в {i} строке, в {j} столбце");
            }
            Console.WriteLine($"Искомого элемента {m} в массиве нет");
            
             
        }  
    }
    
}
 
int [,] array = generate2DDoubleArray (3,5,0,10);
int m = GetUserData ("Введите искомый элемент");
print2DArray(array);
FindElement(m,array);
