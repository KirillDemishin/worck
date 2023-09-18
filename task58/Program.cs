// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");

    }
}

int[,] matrixA = CreateMatrixRndInt(4, 2, 1, 9);
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = CreateMatrixRndInt(2, 3, 1, 9);
PrintMatrix(matrixB);

int rowA = matrixA.GetLength(0);
int colA = matrixA.GetLength(1);
int rowB = matrixB.GetLength(0);
int colB = matrixB.GetLength(1);

int[,] product = new int[rowA, colB];

if (colA != rowB)
{
    Console.WriteLine("Умножение матриц невозможно!");
    return;
}


for (int i = 0; i < rowA; i++)
{
    for (int j = 0; j < colB; j++)
    {
        for (int k = 0; k < colA; k++)
        {
            product[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}

System.Console.WriteLine();
PrintMatrix(product);




    
