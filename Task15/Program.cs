// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
int numberDay = Convert.ToInt32(Console.ReadLine());
void NumberDay(int num)
{
    if (1 <= num & num <= 5) Console.WriteLine($"{num} -> нет");
    if (6 <= num & num <= 7) Console.WriteLine($"{num} -> да");
}
NumberDay(numberDay);