// Задать массив из 12 элементов, заполненный случайными числами от -9 до 9
// Найти сумму отриц и положит чисел

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[12];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
} 

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int GetSumPositiveElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }
    return sum;
}

int GetSumNegativeElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
    return sum;
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int sumNegative = GetSumNegativeElements(arr);
int sumPositive = GetSumPositiveElements(arr);

Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumPositive}");