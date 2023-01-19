// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Введите количество элементов в массиве: ");
int currentSize = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRandomDoubles(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double number = rnd.NextDouble() * 100;
        array[i] = Math.Round(number, 1);
    }
    return array;
} 

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i ++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i ++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}


double[] arr = CreateArrayRandomDoubles(currentSize);
PrintArray(arr);
double maxNumber = MaxNumber(arr);
double minNumber = MinNumber(arr);
double diff = Math.Round(maxNumber - minNumber, 1);

Console.WriteLine($"Максимальное число в массиве - {maxNumber}");
Console.WriteLine($"Максимальное число в массиве - {minNumber}");
Console.WriteLine($"Разница между максимальным и минимальным значением массива - {diff}");