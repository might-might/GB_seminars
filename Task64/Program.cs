﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NumberToN(int n)
{
    if (n == 0) return;
    if (n != 1) Console.Write($"{n}, ");
    else Console.Write($"{n}");
    NumberToN(n - 1);
}


Console.Write("Введите целое число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number <= 0)
{
    Console.Write("Вы ввели неверное число! Повторите ввод: ");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"{number} -> \"");
NumberToN(number);
Console.Write("\"");
