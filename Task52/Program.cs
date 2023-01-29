// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Задайте количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
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

void PrintMatrix(int[,] matrix)
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

void AverageInColumns(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        double avg = (double)sum / matrix.GetLength(0);
        avg = Math.Round(avg, 1, MidpointRounding.ToEven);
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} - {avg}");
    }
}

int[,] array2D = CreateMatrixRandomInt(m, n, 1, 100);
PrintMatrix(array2D);
AverageInColumns(array2D);