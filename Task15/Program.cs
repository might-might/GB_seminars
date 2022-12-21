// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
int numberDay = Convert.ToInt32(Console.ReadLine());
if (1 <= numberDay & numberDay <= 5) Console.WriteLine($"{numberDay} -> нет");
if (6 <= numberDay & numberDay <= 7) Console.WriteLine($"{numberDay} -> да");