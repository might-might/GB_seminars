// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= numberN)
{
if (i < numberN - 1)
{
Console.Write(i + ", ");
}
else
{
Console.WriteLine(i);
}
i += 2;
}