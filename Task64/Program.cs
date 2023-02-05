// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int[] NumberToN(int n)
{
    int[] array = new int[n];
    for (int i = 0; n - i > 0; i++)
    {
        array[i] = n - i;
    }
    return array;
}

void PrintNumbers(int n)
{
    int[] array = NumberToN(n);
    Console.Write($"{n} -> ");
    Console.Write("\"");
    for (int i = 0; i < n; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("\"");
}

Console.Write("Введите целое число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number <= 0)
{
    Console.Write("Вы ввели неверное число! Повторите ввод: ");
    number = Convert.ToInt32(Console.ReadLine());
}

NumberToN(number);
PrintNumbers(number);