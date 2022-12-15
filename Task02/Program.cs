Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.Write("Из введенных чисел максимальное - ");
    Console.WriteLine(numberA);
}

else if (numberB > numberA)
{
    Console.WriteLine($"Из введенных чисел максимальное - {numberB}");
}
else
{
    Console.WriteLine("Числа равны!");
}