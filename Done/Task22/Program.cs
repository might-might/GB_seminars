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
            Console.WriteLine($"{counter, 3}     {Math.Pow(counter, 2)}");
            counter++;
        }
    }
}

SqrtTable(number);