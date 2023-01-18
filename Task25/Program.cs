// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int number2 = int.Parse(Console.ReadLine());
while (number2 < 0)
{
    Console.WriteLine("Вы ввели ненатуральное число. Попробуйте снова.");
    Console.WriteLine("Введите натуральное число");
    number2 = int.Parse(Console.ReadLine());
}

int numberQuad(int num1, int num2)
{
    int result = num1;
    for (int i = 2; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}
Console.WriteLine(numberQuad(number1, number2));