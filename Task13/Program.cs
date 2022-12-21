// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите натуральное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

void ThirdDigit(int num)
{
    int counter = 1;
    int result = num / 10;
    while (counter < result)
    {
        if (result < 10)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else if (10 * counter <= result & result < 100 * counter)
        {
            Console.WriteLine($"Третья цифра - {num / counter % 10}");
        }
        counter *= 10;
    }
} 
ThirdDigit(numberA);