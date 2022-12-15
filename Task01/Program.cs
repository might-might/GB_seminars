Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}

else
{
    Console.WriteLine($"Число {numberA} не является квадратом числа {numberB}");
}