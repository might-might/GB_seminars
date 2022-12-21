void AdivB(int numA, int numB)
{
    Console.WriteLine("Введите первое число:");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int result = numberA % numberB;
    if (result != 0)
        {
            Console.WriteLine($"не кратно, остаток {numberA % numberB}");
        }
    else
    {
        Console.WriteLine($"Число {numberA} кратно числу {numberB}");
    }
}
AdivB(20, 10);