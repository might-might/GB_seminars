// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 10000 < 1 || number / 10000 >= 10) Console.WriteLine("Вы ввели некорректное число.");
else
{
    if (Palindrome(number)) Console.WriteLine($"{number} -> да");
    else Console.WriteLine($"{number} -> нет");
}

bool Palindrome(int num)
{
    int digit1 = num / 10000;
    int digit2 = num / 1000 % 10;
    int digit4 = num / 10 % 10;
    int digit5 = num % 10;
    if (digit5 == digit1 && digit4 == digit2) return true;
    else return false;
}
