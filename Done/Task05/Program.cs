// Задача 5: Напишите программу, которая на вход принмает одно число N, а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int counter = -numberN;
while (counter <= numberN)
{
    if (counter < numberN)
    {
        Console.Write(counter + ", ");
    }
    else if (counter == numberN)
    {
        Console.WriteLine(numberN);
    }
    counter += 1;
}