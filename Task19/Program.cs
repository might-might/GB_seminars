// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 10000 < 1) Console.WriteLine("Вы ввели некорректное число.");
else
{
    if (Palindrome(number)) Console.WriteLine($"{number} -> да");
    else Console.WriteLine($"{number} -> нет");
}

bool Palindrome(int num)
{
    // int digit1 = num / 10000;
    // int digit2 = num / 1000 % 10;
    // int digit3 = num / 100 % 10;
    // int digit4 = num / 10 % 10;
    // int digit5 = num % 10;
    // if (digit5 == digit1 && digit4 == digit2) return true;
    // else return false;
    
    // int digit6 = num / 100000;
    // int digit5 = num / 10000;
    // int digit4 = num / 1000 % 10;
    // int digit3 = num / 100 % 10;
    // int digit2 = num / 10 % 10;
    // int digit1 = num % 10;
    // if (digit1 == digit6 && digit2 == digit5 && digit3 == digit4) return true;
    // else return false;
    
    // int digit7 = num / 1000000;
    // int digit6 = num / 100000;
    // int digit5 = num / 10000;
    // int digit4 = num / 1000 % 10;
    // int digit3 = num / 100 % 10;
    // int digit2 = num / 10 % 10;
    // int digit1 = num % 10;
    // if (digit1 == digit7 && digit2 == digit6 && digit3 == digit5) return true;
    // else return false;
    
    int digit8 = num / 10000000;
    int digit7 = num / 1000000 % 10;
    int digit6 = num / 100000 % 10;
    int digit5 = num / 10000 % 10;
    int digit4 = num / 1000 % 10;
    int digit3 = num / 100 % 10;
    int digit2 = num / 10 % 10;
    int digit1 = num % 10;
    if (digit1 == digit8 && digit2 == digit7 && digit3 == digit6 && digit4 == digit5) return true;
    else return false;
    //  Console.WriteLine(digit1);
}
// Palindrome(number);