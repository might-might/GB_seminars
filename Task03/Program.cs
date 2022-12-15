Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA == 1)
{
    Console.WriteLine($"{numberA} - это понедельник");
}
else if (numberA == 2)
{
    Console.WriteLine($"{numberA} - это вторник");
}
else if (numberA == 3)
{
    Console.WriteLine($"{numberA} - это среда");
}
else if (numberA == 4)
{
    Console.WriteLine($"{numberA} - это четверг");
}
else if (numberA == 5)
{
    Console.WriteLine($"{numberA} - это пятница");
}
else if (numberA == 6)
{
    Console.WriteLine($"{numberA} - это суббота");
}
else if (numberA == 7)
{
    Console.WriteLine($"{numberA} - это воскресенье");
}