Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());

void AdivB(int numA, int numB)
{
    int result = numberA % numberB;
    if (result != 0)
        {
            Console.WriteLine($"Число {numberA} не кратно числу {numberB}, остаток {numberA % numberB}");
        }
    else
    {
        Console.WriteLine($"Число {numberA} кратно числу {numberB}");
    }
}
AdivB(numberA, numberB);