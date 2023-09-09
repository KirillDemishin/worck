// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");

    }
}
int row = 3;
int col = 4;
int[,] array2d = CreateMatrixRndInt(row, col, 1, 9);
PrintMatrix(array2d);

Console.WriteLine("Введите строки");
int rowsNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец");
int columnsNum = Convert.ToInt32(Console.ReadLine());
rowsNum -= 1;
columnsNum -=1;

if (rowsNum < array2d.GetLength(0) && columnsNum < array2d.GetLength(1)) Console.WriteLine(array2d[rowsNum, columnsNum]);
else Console.WriteLine($"Значение этой строки {rowsNum +1} и этого столбца {columnsNum +1} -> нет в массиве");





