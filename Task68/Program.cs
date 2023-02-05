// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunc(int m, int n)
{   
    if (m == 0) return n + 1;
    else if (n == 0) return AckermanFunc(m - 1, 1);
    return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
}

void GetSum(int numM, int numN)
{
    Console.WriteLine(AckermanFunc(numM, numN));
}

Console.Write("Введите первое целое число больше нуля: ");
int numberM = Convert.ToInt32(Console.ReadLine());
while (numberM <= 0)
{
    Console.Write("Вы ввели неверное число! Повторите ввод: ");
    numberM = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите второе целое число больше нуля: ");
int numberN = Convert.ToInt32(Console.ReadLine());
while (numberN <= 0)
{
    Console.Write("Вы ввели неверное число! Повторите ввод: ");
    numberN = Convert.ToInt32(Console.ReadLine());
}
GetSum(numberM, numberN);