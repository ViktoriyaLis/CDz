/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}
double [,] get2DDoubleArray(int colLength, int rowLength, int start, int finish)
{
    double [,] array = new double[colLength,rowLength];
    for (int i = 0; i < colLength; i++)
    {   
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = (double)new Random().Next(start, finish+1)+Math.Round(new Random().NextDouble(),2);
        }
    }
    return array;
}
void print2DArray (double[,]array)
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
int m = GetUserData ("Введите количество строк");
int n = GetUserData ("Введите количество стобцов");
double[,]array = get2DDoubleArray(m,n,0,100);
print2DArray(array);

