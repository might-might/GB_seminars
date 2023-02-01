﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRandomInt1(int rows, int columns, int min, int max)
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

int[,] CreateMatrixRandomInt2(int rows, int columns, int min, int max)
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

int[,] ProdMatrix(int[,] matrix1,int[,] matrix2)
{
    // if (matrix1.GetLength(1) == matrix2.GetLength(0))
    // {
    int prod = 0;
    int rows = matrix2.GetLength(0);//количество строк новой матрицы
    int columns = matrix1.GetLength(1);//количество столбцов новой матрицы

    int[,] newMatrix = new int[rows, columns];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            // for (int k = 0; k < )
            newMatrix[i, j] = matrix1[i, j] * matrix2[i, j] + matrix1[i, j + 1] * matrix2[i + 1, j];
        }
    }
    return newMatrix;
    // }
    // else
    // {
    //     Console.WriteLine("Эти матрицы нельзя перемножить!");
    // }
}  

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("");
    }
}

int[,] matrix_1 = CreateMatrixRandomInt1(2, 2, 1, 5);
int[,] matrix_2 = CreateMatrixRandomInt2(2, 2, 1, 5);
int[,] matrix_f = ProdMatrix(matrix_1, matrix_2);
PrintMatrix(matrix_1);
PrintMatrix(matrix_2);
PrintMatrix(matrix_f);
