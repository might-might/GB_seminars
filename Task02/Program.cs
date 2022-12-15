// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.Write("Их введенных чисел максимальное - ");
    Console.WriteLine(numberA);
}

else if (numberB > numberA)
{
    // Console.Write("Из введенных чисел максимальное - ");
    // Console.WriteLine(numberB);
    Console.WriteLine($"Из введенных чисел максимальное - {numberB}");
}
else
{
    Console.WriteLine("Числа равны!");
}


// Альтернативный вариант:

// Console.WriteLine("Введите первое число: ");
// string a = Console.ReadLine();
// Console.WriteLine("Введите второе число: ");
// string b = Console.ReadLine();
// int a1 = int.Parse(a);
// int b1 = int.Parse(b);
// if (a1 > b1)
// {
//     Console.Write("Их введенных чисел максимальное - ");
//     Console.WriteLine(a1);
// }

// else
// {
//     Console.Write("Их введенных чисел максимальное - ");
//     Console.WriteLine(b1);
// }