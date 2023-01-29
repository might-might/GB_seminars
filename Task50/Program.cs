// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите строку элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max)
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

void CheckPrintCell(int[,] matrix, int a, int b)
{
    if (a == 0 || b == 0 || a > matrix.GetLength(0) || b > matrix.GetLength(1))
    {
        Console.WriteLine($"({a},{b}) -> Такой ячейки в массиве нет");
    }
    else Console.WriteLine($"В ячейке ({a},{b}) находится элемент {matrix[a - 1, b - 1]}");
}

void PrintNumber(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 6}, ");
            else Console.Write($"{matrix[i, j], 6}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRandomInt(5, 5, 1, 100);
PrintNumber(array2D);
CheckPrintCell(array2D, m, n);