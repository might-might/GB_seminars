// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Задайте количество строк и столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRandomIntQuad(int lines, int min, int max)
{
    int[,] matrix = new int[lines, lines];
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

// В прошлом ДЗ мне понизили балл за то, что я распечатал массив. Тут специально комментирую) 
// Как по мне, так легче посмотреть, наглядно и удобно, только из этих соображений добавляю эти
// методы.
// 
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

void MinSumLine(int[,] matrix)
{
    int minLine = 0;
    int minSum = 0;
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSum += matrix[0, j];
    }
    // Console.WriteLine(minSum);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        // Console.WriteLine(sum);
        // также для удобной проверки, комментирую)
        if (sum < minSum)
        {
            minSum = sum;
            minLine = i + 1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minLine} строка");
}

int[,] arrayQuad = CreateMatrixRandomIntQuad(m, 1, 100);
// PrintMatrix(arrayQuad);
MinSumLine(arrayQuad);