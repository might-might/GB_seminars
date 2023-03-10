// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumberFromMtoN(int m, int n)
{
    if (m == n) return n;
    if (m < 0) m = 0;
    if (m < n)
    {
        NumberFromMtoN(m + 1, n);
        return m;
    }
    else
    {
        NumberFromMtoN(m - 1, n);
        return m;
    }
}

void GetSum(int numM, int numN)
{
    if (numM < 0 && numN < 0)
    {
        Console.WriteLine($"Вы ввели два отрицательных числа. Между ними нет натуральных чисел, сумма не найдена.");
    }
    else if (numM > numN)
    {
        int numK = numN;
        numN = numM;
        numM = numK;
        int sum = 0;
        for (int i = 0; i <= numN - numM; i++)
        {
            sum += NumberFromMtoN(numM + i, numN);
        }
        Console.WriteLine($"Сумма натуральных чисел между числами {numM} и {numN} равна {sum}.");
    }
    else
    {
        int sum = 0;
        for (int i = 0; i <= numN - numM; i++)
        {
            sum += NumberFromMtoN(numM + i, numN);
        }
        Console.WriteLine($"Сумма натуральных чисел между числами {numM} и {numN} равна {sum}.");
    }
}



Console.Write("Введите первое целое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
GetSum(numberM, numberN);