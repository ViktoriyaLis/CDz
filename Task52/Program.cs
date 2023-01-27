/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse (Console.ReadLine()!);
    return userData;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(data);
    Console.ResetColor();
}

int[,] generate2DArray(int colLenght, int rowLenght, int start, int end)
{
    int[,] result = new int[colLenght, rowLenght];
    for (int i=0; i< colLenght; i++)
    {
        for (int j=0; j< rowLenght; j++)
        {
           result[i,j]= new Random().Next(start, end+1);
        }
    }
    return result;
}
void print2DArray (int[,] arr)
{
    Console.Write(" \t");
    for (int j=0; j< arr.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i=0; i< arr.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j=0; j< arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void ArifmeticMean ( int[,]array)
{
    double result = 0;
    Console.WriteLine($"Cреднее арифметическое чисел в каждом столбце:");
    for (int j=0; j< array.GetLength(1); j++)
    {
        for (int i=0; i< array.GetLength(0); i++)
        {
           result += array[i,j];
        }
        Console.WriteLine(Math.Round(result/array.GetLength(0),2));
        result = 0;
    }
}

int col = getUserData("Введите количество строк в массиве");
int row = getUserData("Введите количество столбцов в массиве");
int[,]array = generate2DArray(col, row, 0, 50);
print2DArray(array);
ArifmeticMean(array);