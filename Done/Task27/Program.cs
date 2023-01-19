// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
while (number1 < 0)
{
    Console.WriteLine("Вы ввели ненатуральное число. Попробуйте снова.");
    Console.WriteLine("Введите натуральное число");
    number1 = int.Parse(Console.ReadLine());
}

int sum = 0;
int SumNumbers(int num)
{
    while (num > 0)
    {
        sum = num % 10 + sum;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine(SumNumbers(number1));