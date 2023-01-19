// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

void SqrtTable(int num)
{
    if (num <= 0) Console.WriteLine("Вы ввели некорректное число");
    else
    {
        int counter = 1;
        while (counter <= num)
        {
            Console.WriteLine($"{counter} | {Math.Pow(counter, 3)}");
            counter++;
        }
    }
}

SqrtTable(number);