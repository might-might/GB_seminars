// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine($"Из введенных чисел максимальное - {numberA}");
    }
    else if (numberC > numberA)
    {
        Console.WriteLine($"Из введенных чисел максимальное - {numberC}");
    }
    else if (numberC == numberA)
    {
        Console.WriteLine($"Из введенных чисел максимальное - {numberC}. Вы ввели его дважды.");
    }
}
else if (numberB > numberA)
{
    if (numberB > numberC)
    {
        Console.WriteLine($"Из введенных чисел максимальное - {numberB}");
    }
    else if (numberC > numberB)
    {
        Console.WriteLine($"Из введенных чисел максимальное - {numberC}");
    }
    else if (numberC == numberB)
    {
        Console.WriteLine($"Из введенных чисел максимальное - {numberC}. Вы ввели его дважды.");
    }
}
else if (numberA == numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine($"Из введенных чисел максимальное - {numberA}. Вы ввели его дважды.");
    }
    else if (numberC > numberA)
    {
        Console.WriteLine($"Из введенных чисел максимальное - {numberC}");
    }
    else if (numberC == numberA)
    {
        Console.WriteLine($"Вы ввели три одинаковых числа!");
    }
}