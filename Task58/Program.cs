/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/ 
/*void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

int[,] get2DArray( int colLenght, int rowLenght, int start, int end)
{
    int[,] array = new int[colLenght, rowLenght];
    for (int i = 0; i < colLenght; i++)
    {
        for (int j = 0; j < rowLenght; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

void print2DArray(int[,] array)
{
    Console.Write("\t");
        for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
        {
            printInColor(i + "\t");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
}
static double[][] MatrixProduct(double[][] matrixA,
      double[][] matrixB)
    {
      int aRows = matrixA.Length; int aCols = matrixA[0].Length;
      int bRows = matrixB.Length; int bCols = matrixB[0].Length;
      if (aCols != bRows)
        throw new Exception("Non-conformable matrices in MatrixProduct");
      double[][] result = MatrixCreate(aRows, bCols);
      for (int i = 0; i < aRows; ++i) // каждая строка A
        for (int j = 0; j < bCols; ++j) // каждый столбец B
          for (int k = 0; k < aCols; ++k)
            result[i][j] += matrixA[i][k] * matrixB[k][j];
      return result;
    }